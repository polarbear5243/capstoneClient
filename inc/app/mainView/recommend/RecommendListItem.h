#pragma once
#include <gui/object/ListItem.h>
#include <gui/layout/Naviframe.h>

#include "app/mainView/recipe/RecipeInfo/RecipeInfoView.h"

class RecommendListItem : public ListItem{
private:
	Naviframe* mNaviframe;
	string mRecipeId;
	string mName;

public:
	RecommendListItem(string recipeName, string recipeId, Naviframe * naviframe) : ListItem(recipeName) {
		mRecipeId = recipeId;
		mNaviframe = naviframe;
	}
	void selected(){
		RecipeInfoView* s = new RecipeInfoView(mNaviframe, mRecipeId);
	}
	string getName(){ return mName; }
};
