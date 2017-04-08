#include"gui/object/Button.h"
#include"gui/layout/Naviframe.h"
#include"app/DataModel/Groceries.h"
#include"app/DataModel/UserInfo.h"

#include"app/mainView/food/foodMain/BreakCycle.h"

#include"FoodModifySocket.h"

class FoodModifyDeleteButton : public Button{
public:
	BreakCycle * mMainList;
	void * mTargetItem;
	Naviframe * mNaviframe;
	string mName;
	string mId;

	FoodModifyDeleteButton(UILayout parent, BreakCycle * mainList, void * targetItem, Naviframe * navi, string name, string id) : Button(parent) {
		this->setText("삭제");
		mMainList = mainList;
		mTargetItem = targetItem;
		mNaviframe = navi;
		mName = name;
		mId = id;
	}
	void click()
	{
		UserInfo * myInfo = UserInfo::getInstance();
		string id = myInfo->getMyId();

		FoodModifySocket socket;

		bool result = socket.deleteUserIngredient(id,mName);

		if(result){
			myInfo->deleteGroceries(mName);
			mMainList->deleteFoodItem(mTargetItem);
			mNaviframe->popItem();
		}
		else
		{
			Popup* toast = new Popup();
			toast->setStyle("toast");
			elm_object_text_set(toast->getContent(), "삭제 실패");
			toast->setTimeout(2.0);
		}
	}
};
