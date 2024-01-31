import 'package:flutter/material.dart';
import 'package:mod5/widgets/chart/chart.dart';
import 'package:mod5/widgets/expenses_list/expenses_list.dart';
import 'package:mod5/models/expense.dart';
import 'package:mod5/widgets/expenses_list/new_expense.dart';

class Expenses extends StatefulWidget {
  const Expenses({super.key});

  @override
  State<StatefulWidget> createState() {
    return _ExpensesState();
  }
}

class _ExpensesState extends State<Expenses> {
  final List<Expense> _registeredExpenses = [
    Expense(
      tittle: 'Flutter',
      amount: 9.99,
      date: DateTime.now(),
      category: Category.work,
    ),
    Expense(
      tittle: 'Cinema',
      amount: 9.99,
      date: DateTime.now(),
      category: Category.leisure,
    ),
  ];

  void _openAddBarra() {
    showModalBottomSheet(
      useSafeArea: true,
      isScrollControlled: true,
      context: context,
      builder: (ctx) => NewExpense(onAddExpense: _addExpense),
    );
  }

  void _addExpense(Expense expense) {
    setState(() {
      _registeredExpenses.add(expense);
    });
  }

  void _removeExpense(Expense expense) {
    final expenseIndex = _registeredExpenses
        .indexOf(expense); //salva os dados pra ter como refazer
    setState(() {
      _registeredExpenses.remove(expense);
    });
    ScaffoldMessenger.of(context)
        .clearSnackBars(); //se remover varias num fica varias mensagens ja corta pra ultima
    ScaffoldMessenger.of(context).showSnackBar(
      // mostrar barra pra desfazer a remoção
      SnackBar(
        duration: const Duration(seconds: 3),
        content: const Text('Despesa Removida'),
        action: SnackBarAction(
          label: 'Desfazer',
          onPressed: () {
            setState(() {
              _registeredExpenses.insert(expenseIndex, expense);
            });
          },
        ),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    final width = (MediaQuery.of(context).size.width);
    print(MediaQuery.of(context).size.height);

    Widget mainContent = const Center(
      child: Text('Nenhuma despesa encontrada. Comece adicionando uma!'),
    );

    if (_registeredExpenses.isNotEmpty) {
      mainContent = ExpensesList(
        expenses: _registeredExpenses,
        onRemoveExpense: _removeExpense,
      );
    }

    return Scaffold(
      appBar: AppBar(
        title: const Text('barraa'),
        actions: [
          IconButton(onPressed: _openAddBarra, icon: const Icon(Icons.add))
        ],
      ),
      body: width < 600
          ? Column(
              children: [
                Chart(expenses: _registeredExpenses),
                Expanded(
                  child: mainContent,
                ),
              ],
            )
          : Row(
              children: [
                Expanded(
                  child: Chart(expenses: _registeredExpenses),
                ),
                Expanded(
                  child: mainContent,
                ),
              ],
            ),
    );
  }
}
