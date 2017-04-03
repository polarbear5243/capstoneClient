#pragma once
#include <gui/layout/UILayout.h>
#include <gui/object/Button.h>

using namespace std;

class NaviItem:public UILayout{
private:
	static Eina_Bool static_pop_cb(void *data, Elm_Object_Item *it);

public:
	NaviItem(Evas_Object * na_it);
	void setStyle(NaviItem item, string style);
	void setTitleEnalble(bool enabled, bool transition);
	void setTitle(string title);
	void setSubTitle(string title);
	void setLeftTopBtn(Button btn);
	void setRightTopBtn(Button btn);
	void unSetLeftTopBtn();
	void unSetRightTopBtn();
	void setFinalNavi();
	void unSetFinalNavi();
	virtual ~NaviItem();
};
