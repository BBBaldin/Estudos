import 'package:flutter_riverpod/flutter_riverpod.dart';
import 'package:food_app/models/meal.dart';

class FavoriteMealsNotifier extends StateNotifier<List<Meal>> {
  FavoriteMealsNotifier() : super([]);

  bool toggleMealFavoriteStatus(Meal meal) {
    final mealsFavorite = state.contains(meal); //recebe os fav

    if (mealsFavorite) {
      state = state.where((m) => m.id != meal.id).toList();
      return false;
      //verifica se esta no fav, se nao ta, remove da lista
    } else {
      state = [...state, meal]; //adiciona os fav na nova lista
      return true;
    }
  }
}

final favoriteMealsProvider =
    StateNotifierProvider<FavoriteMealsNotifier, List<Meal>>((ref) {
  return FavoriteMealsNotifier();
});
