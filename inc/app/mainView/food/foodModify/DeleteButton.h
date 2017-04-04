#include"gui/object/Button.h"

namespace FM{
	class DeleteButton : public Button{
	public:
		DeleteButton(UILayout parent) : Button(parent) {
			this->setText("삭제");
		}
		void click()
		{

		}
	};
}
