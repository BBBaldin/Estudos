import 'package:flutter/material.dart';
import 'package:shopping_list_app/models/grocery_item.dart';
import 'package:shopping_list_app/widgets/new_item.dart';

class GroceryList extends StatefulWidget {
  const GroceryList({super.key});

  @override
  State<GroceryList> createState() => _GroceryListState();
}

class _GroceryListState extends State<GroceryList> {
  final List<GroceryItem> _groceryItems = [];

  void _addItem() async {
    final newItem = await Navigator.of(context).push<GroceryItem>(
      MaterialPageRoute(
        builder: (ctx) => const NewItem(),
      ),
    );

    if (newItem == null) {
      return;
    }

    setState(() {
      _groceryItems.add(newItem);
    });
  }

  void _removeItem(GroceryItem item) {
    final groceryIndex = _groceryItems
        .indexOf(item); //salva os dados pra ter como refazer
    setState(() {
      _groceryItems.remove(item);
    });
    ScaffoldMessenger.of(context)
        .clearSnackBars(); //se remover varias num fica varias mensagens ja corta pra ultima
    ScaffoldMessenger.of(context).showSnackBar(
      // mostrar barra pra desfazer a remoção
      SnackBar(
        duration: const Duration(seconds: 3),
        content: const Text('Item Removido'),
        action: SnackBarAction(
          label: 'Desfazer',
          onPressed: () {
            setState(() {
              _groceryItems.insert(groceryIndex, item);
            });
          },
        ),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    Widget content = const Center(
        child: Text(
      'Seu Carrinho está vazio.',
      style: TextStyle(
        fontWeight: FontWeight.bold,
        fontSize: 24,
      ),
    ));

    if (_groceryItems.isNotEmpty) {
      content = ListView.builder(
        itemCount: _groceryItems.length,
        itemBuilder: (ctx, index) => Dismissible(
          background: Container(
            color: Colors.red.withOpacity(0.75),
            margin: const EdgeInsets.symmetric(),
          ),
          onDismissed: (direction) {
            _removeItem(_groceryItems[index]);
          },
          key: ValueKey(_groceryItems[index].id),
          child: ListTile(
            title: Text(_groceryItems[index].name),
            leading: Container(
              width: 24,
              height: 24,
              color: _groceryItems[index].category.color,
            ),
            trailing: Text(
              _groceryItems[index].quantity.toString(),
            ),
          ),
        ),
      );
    }

    return Scaffold(
      appBar: AppBar(
        title: const Text('Carrinho de Compras'),
        actions: [
          IconButton(
            onPressed: () {
              _addItem();
            },
            icon: const Icon(Icons.add),
          )
        ],
      ),
      body: content,
    );
  }
}
