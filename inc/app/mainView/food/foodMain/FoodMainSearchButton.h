#pragma once
#include <app/mainView/food/foodMain/FoodMainFoodList.h>
#include"gui/object/Button.h"
#include"gui/object/Entry.h"


class FoodMainSearchButton : public Button {
private:
	Entry * mSearchEntry;
	FoodMainFoodList * mFoodList;
public:
	FoodMainSearchButton(UILayout parent, Entry * searchEntry, FoodMainFoodList * foodList) : Button(parent) {
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
