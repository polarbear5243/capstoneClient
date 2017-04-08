#pragma once
#include <app/mainView/food/foodAdd/FoodAddView.h>
#include"gui/object/Button.h"
#include"gui/layout/Naviframe.h"

class FoodMainAddButton : public Button {
private:
Naviframe * mNaviframe;
FoodMainFoodList * mFoodList;
public:
	FoodMainAddButton(UILayout parent, Naviframe * naviframe, FoodMainFoodList * foodList) : Button(parent) {
		this->setText("추가");
		mNaviframe = naviframe;
		mFoodList = foodList;
	}
	void click()
	{
		new FoodAddView(mNaviframe, mFoodList);
	}
};
