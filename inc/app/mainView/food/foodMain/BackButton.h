#include"gui/object/Button.h"

namespace FoodMain{
	class BackButton : public Button{
	public:
		BackButton(UILayout parent) : Button(parent) {
			this->setText("뒤로");
		}
		void click()
		{

		}
	};
}
