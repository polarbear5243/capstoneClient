#pragma once
#include"gui/object/Button.h"
#include"gui/layout/Naviframe.h"

class FoodMainBackButton : public Button{
protected:
	Naviframe * mParent;
public:
	FoodMainBackButton(UILayout parent, Naviframe * navi) : Button(parent) {
		this->setText("뒤로");
		mParent = navi;
	}
	void click()
	{
		mParent->popItem();
	}
};
