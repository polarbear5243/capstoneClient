// 에디드 박스 만들기 - 참고
//elm_layout_theme_set(editfield, "layout", "editfield", "singleline");

#pragma once
#include <gui/layout/UILayout.h>
#include"Object.h"
#include<string>

using namespace std;

class ListItem:public Object
{
private:
	static void selected_cb(void *data, Evas_Object *obj, void *event_info);
protected:
	string mTitle;
	Elm_Object_Item * mContent;
public:
	ListItem(string title);

protected:
	virtual void selected();

	friend class List;
};
