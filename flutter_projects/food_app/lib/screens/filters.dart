import 'package:flutter/material.dart';

enum Filter {
  glutenFree,
  lactoseFree,
  vegetarin,
  vegan,
}

class FiltersScreen extends StatefulWidget {
  const FiltersScreen({
    super.key,
    required this.currentFilters,
  });

  final Map<Filter, bool> currentFilters;

  @override
  State<StatefulWidget> createState() {
    return _FiltersScreenState();
  }
}

class _FiltersScreenState extends State<FiltersScreen> {
  var _glutenFreeFIlterSet = false;
  var _lactoseFreeFIlterSet = false;
  var _vegetarianFreeFIlterSet = false;
  var _veganFreeFIlterSet = false;

  @override
  void initState() {
    super.initState();
  _glutenFreeFIlterSet = widget.currentFilters[Filter.glutenFree]!;
  _lactoseFreeFIlterSet = widget.currentFilters[Filter.lactoseFree]!;
  _vegetarianFreeFIlterSet = widget.currentFilters[Filter.vegetarin]!;
  _veganFreeFIlterSet = widget.currentFilters[Filter.vegan]!;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Seus Filtros'),
      ),
      body: PopScope(
        canPop: false,
        onPopInvoked: (bool didPop) {
          if (didPop) return;
          Navigator.of(context).pop({
            Filter.glutenFree: _glutenFreeFIlterSet,
            Filter.lactoseFree: _lactoseFreeFIlterSet,
            Filter.vegetarin: _vegetarianFreeFIlterSet,
            Filter.vegan: _veganFreeFIlterSet,
          });
        },
        child: Column(
          children: [
            SwitchListTile(
              value: _glutenFreeFIlterSet,
              onChanged: (isChecked) {
                setState(() {
                  _glutenFreeFIlterSet = isChecked;
                });
              },
              title: Text(
                'Gluten-free',
                style: Theme.of(context).textTheme.titleLarge!.copyWith(
                      color: Theme.of(context).colorScheme.onBackground,
                    ),
              ),
              subtitle: Text(
                'Apenas Alimentos sem Glúten',
                style: Theme.of(context).textTheme.labelMedium!.copyWith(
                      color: Theme.of(context).colorScheme.onBackground,
                    ),
              ),
              activeColor: Theme.of(context).colorScheme.tertiary,
              contentPadding: const EdgeInsets.only(
                left: 34,
                right: 22,
              ),
            ),
            SwitchListTile(
              value: _lactoseFreeFIlterSet,
              onChanged: (isChecked) {
                setState(() {
                  _lactoseFreeFIlterSet = isChecked;
                });
              },
              title: Text(
                'Lactose-free',
                style: Theme.of(context).textTheme.titleLarge!.copyWith(
                      color: Theme.of(context).colorScheme.onBackground,
                    ),
              ),
              subtitle: Text(
                'Apenas Alimentos sem Lactose',
                style: Theme.of(context).textTheme.labelMedium!.copyWith(
                      color: Theme.of(context).colorScheme.onBackground,
                    ),
              ),
              activeColor: Theme.of(context).colorScheme.tertiary,
              contentPadding: const EdgeInsets.only(
                left: 34,
                right: 22,
              ),
            ),
            SwitchListTile(
              value: _vegetarianFreeFIlterSet,
              onChanged: (isChecked) {
                setState(() {
                  _vegetarianFreeFIlterSet = isChecked;
                });
              },
              title: Text(
                'Vegetarian',
                style: Theme.of(context).textTheme.titleLarge!.copyWith(
                      color: Theme.of(context).colorScheme.onBackground,
                    ),
              ),
              subtitle: Text(
                'Apenas Alimentos Vegetarianos',
                style: Theme.of(context).textTheme.labelMedium!.copyWith(
                      color: Theme.of(context).colorScheme.onBackground,
                    ),
              ),
              activeColor: Theme.of(context).colorScheme.tertiary,
              contentPadding: const EdgeInsets.only(
                left: 34,
                right: 22,
              ),
            ),
            SwitchListTile(
              value: _veganFreeFIlterSet,
              onChanged: (isChecked) {
                setState(() {
                  _veganFreeFIlterSet = isChecked;
                });
              },
              title: Text(
                'Vegan',
                style: Theme.of(context).textTheme.titleLarge!.copyWith(
                      color: Theme.of(context).colorScheme.onBackground,
                    ),
              ),
              subtitle: Text(
                'Apenas Alimentos Veganos',
                style: Theme.of(context).textTheme.labelMedium!.copyWith(
                      color: Theme.of(context).colorScheme.onBackground,
                    ),
              ),
              activeColor: Theme.of(context).colorScheme.tertiary,
              contentPadding: const EdgeInsets.only(
                left: 34,
                right: 22,
              ),
            ),
          ],
        ),
      ),
    );
  }
}
