#include"gui/object/Button.h"

class FoodModifyFavoritesButton : public Button{
public:
	FoodModifyFavoritesButton(UILayout parent) : Button(parent) {
		this->setText("즐겨찾기");
	}
	void click()
	{

	}
};
