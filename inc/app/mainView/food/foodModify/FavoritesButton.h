#include"gui/object/Button.h"

namespace FM{
	class FavoritesButton : public Button{
	public:
		FavoritesButton(UILayout parent) : Button(parent) {
			this->setText("즐겨찾기");
		}
		void click()
		{

		}
	};
}
