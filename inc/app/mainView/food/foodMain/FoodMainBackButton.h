#pragma once
#include"gui/object/Button.h"

class FoodMainBackButton : public Button{
public:
	FoodMainBackButton(UILayout parent) : Button(parent) {
		this->setText("뒤로");
	}
	void click()
	{

	}
};
