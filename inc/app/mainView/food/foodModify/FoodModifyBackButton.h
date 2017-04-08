#include"gui/object/Button.h"
#include"gui/layout/Naviframe.h"

class FoodModifyBackButton : public Button{
	Naviframe * mNaviframe;
public:
	FoodModifyBackButton(UILayout parent, Naviframe * navi) : Button(parent) {
		this->setText("뒤로");
		mNaviframe = navi;
	}
	void click()
	{
		mNaviframe->popItem();
	}
};
