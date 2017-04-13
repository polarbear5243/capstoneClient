#pragma once
#include <gui/object/ListItem.h>
#include <gui/layout/Naviframe.h>

#include "app/mainView/recipe/RecipeInfo/RecipeInfoView.h"

class RecipeListRecipeItem : public ListItem{
private:
	Naviframe* mNaviframe;
	string mRecipeId;
	string mName;

public:
	RecipeListRecipeItem(string recipeName, string recipeId, Naviframe * naviframe) : ListItem(recipeName) {
		mRecipeId = recipeId;
		mNaviframe = naviframe;
	}
	void selected(){
		RecipeInfoView* s = new RecipeInfoView(mNaviframe, mRecipeId);
	}
	string getName(){ return mName; }
};
