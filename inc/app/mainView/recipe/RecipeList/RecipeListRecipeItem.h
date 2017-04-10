#pragma once
#include <gui/object/ListItem.h>
#include <gui/layout/Naviframe.h>

#include "app/mainView/recipe/RecipeInfo/RecipeInfoView.h"

class ReceipeListRecipeList : public ListItem{
private:
	Naviframe* mNaviframe;
	string name;
	string howtocook;
	string category;
	//등등...
public:
	ReceipeListRecipeList(string parent, Naviframe * naviframe) : ListItem(parent) {
		name = parent;
		mNaviframe = naviframe;
	}
	void selected(){
		RecipeInfoView* s = new RecipeInfoView(mNaviframe);
	}
	string getName(){ return name; }
};
