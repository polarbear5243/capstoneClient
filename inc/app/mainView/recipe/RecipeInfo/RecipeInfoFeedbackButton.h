#include"gui/object/Button.h"
#include"gui/layout/Naviframe.h"

class RecipeInfoFeedbackButton : public Button{
protected:
public:
	RecipeInfoFeedbackButton(UILayout parent) : Button(parent) {
		this->setText("피드백");
	}
	void click()
	{

	}
};
