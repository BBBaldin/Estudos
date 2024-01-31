import 'package:flutter/material.dart';
import 'package:first_app/gradient_container.dart';

void main() {
  runApp(
    const MaterialApp(
      home: Scaffold(
        body: GradientContainer(
            Color.fromARGB(255, 22, 2, 56),
            Color.fromARGB(255, 41, 4, 105),
            Color.fromARGB(255, 60, 11, 146),
          ),
      ),
    ),
  );
}
