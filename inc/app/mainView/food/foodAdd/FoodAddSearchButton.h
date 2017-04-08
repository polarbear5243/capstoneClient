#pragma once
#include <app/mainView/food/foodAdd/FoodAddFoodList.h>
#include"gui/object/Button.h"
#include"gui/object/Entry.h"

#include<string>

using namespace std;

class FoodAddSearchButton : public Button {
private:
	Entry * mSearchEntry;
	FoodAddFoodList * mFoodList;
public:
	FoodAddSearchButton(UILayout parent, Entry * searchEntry, FoodAddFoodList * foodList) : Button(parent) {
		this->setText("검색");
		mSearchEntry = searchEntry;
		mFoodList = foodList;
	}
	void click()
	{
		if(mSearchEntry == NULL || mFoodList == NULL)
			return;
		string str = mSearchEntry->getText();
		mFoodList->search(str);
	}
};
