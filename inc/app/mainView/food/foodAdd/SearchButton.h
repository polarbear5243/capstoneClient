#include"gui/object/Button.h"

namespace FA{
	class SearchButton : public Button {
	public:
		SearchButton(UILayout parent) : Button(parent) {
			this->setText("검색");
		}
		void click()
		{

		}
	};
}
