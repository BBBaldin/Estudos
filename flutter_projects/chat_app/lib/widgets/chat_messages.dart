import 'package:chat_app/widgets/message_bubble.dart';
import 'package:cloud_firestore/cloud_firestore.dart';
import 'package:firebase_auth/firebase_auth.dart';
import 'package:flutter/material.dart';

class ChatMessages extends StatelessWidget {
  const ChatMessages({super.key});

  @override
  Widget build(BuildContext context) {
    final authenticatedUser = FirebaseAuth.instance.currentUser!;

    return StreamBuilder(
      stream: FirebaseFirestore.instance
          .collection('chat')
          .orderBy(
            'createdAt',
            descending: true, // mensagem mais antiga no topo
          )
          .snapshots(),
      //informa toda vez q tem mudança nos dados na collection 'chat'
      builder: (ctx, chatSnapshots) {
        if (chatSnapshots.connectionState == ConnectionState.waiting) {
          return const Center(
            child: CircularProgressIndicator(),
          );
        }

        if (!chatSnapshots.hasData || chatSnapshots.data!.docs.isEmpty) {
          return const Center(
            child: Text('Você não possui chats ainda'),
          );
        }

        if (chatSnapshots.hasError) {
          return const Center(
            child: Text('Algo deu errado'),
          );
        }

        //trazer as mensagens pro app
        final loadedMessages = chatSnapshots.data!.docs;

        return ListView.builder(
          padding: const EdgeInsets.only(
            bottom: 40,
            left: 13,
            right: 13,
          ),
          reverse: true, //mensagens de baixo pra cima
          itemCount: loadedMessages.length,
          itemBuilder: (ctx, index) {
            final chatMessage = loadedMessages[index].data();
            final nextChatMessage = index + 1 < loadedMessages.length
                ? loadedMessages[index + 1].data() // prox msg
                : null; // se num tiver prox msg, fica como nula

            final currentMessageUserid = chatMessage['userId'];
            final nextMessageUserid =
                nextChatMessage != null ? nextChatMessage['userId'] : null;
            final nextUserIsSame = nextMessageUserid ==
                currentMessageUserid; //se quem ta falando é o msm

            if (nextUserIsSame) {
              return MessageBubble.next(
                message: chatMessage['text'],
                isMe: authenticatedUser.uid == currentMessageUserid,
              );
            } else {
              return MessageBubble.first(
                  userImage: chatMessage['userImage'],
                  username: chatMessage['usernamer'],//usernamer ta errado pq errei no new_message.dart
                  message: chatMessage['text'],
                  isMe: authenticatedUser.uid == currentMessageUserid,);
            }
          },
        );
      },
    );
  }
}
