#include"gui/object/Button.h"
#include"gui/layout/Naviframe.h"
#include"app/mainView/food/foodAdd/FoodAdd.h"

namespace FoodMain{
	class AddButton : public Button
		{
		private:
		Naviframe * mNaviframe;

		public:
			AddButton(UILayout parent, Naviframe * naviframe) : Button(parent) {
				this->setText("추가");
				mNaviframe = naviframe;
			}
			void click()
			{
				new FoodAdd(mNaviframe);
			}
		};
}
