#include"gui/object/Button.h"
#include"gui/layout/Naviframe.h"

class FoodAddBackButton : public Button{
protected:
	Naviframe * mNaviframe;
public:
	FoodAddBackButton(UILayout parent, Naviframe * naviframe) : Button(parent) {
		this->setText("뒤로");
		mNaviframe = naviframe;
	}
	void click()
	{
		mNaviframe->popItem();
	}
};
