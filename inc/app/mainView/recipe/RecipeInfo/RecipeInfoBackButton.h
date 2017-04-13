#include"gui/object/Button.h"
#include"gui/layout/Naviframe.h"

class RecipeInfoBackButton : public Button{
protected:
	Naviframe * mNaviframe;
public:
	RecipeInfoBackButton(UILayout parent, Naviframe * naviframe) : Button(parent) {
		this->setText("뒤로");
		mNaviframe = naviframe;
	}
	void click()
	{
		mNaviframe->popItem();
	}
};
