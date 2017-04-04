// 에디드 박스 만들기 - 참고
//elm_layout_theme_set(editfield, "layout", "editfield", "singleline");

#pragma once
#include <gui/layout/UILayout.h>
#include <gui/object/ListItem.h>
#include"Object.h"
#include<string>

using namespace std;

class List:public Object
{
private:
	static void	list_selected_cb(void *data, Evas_Object *obj, void *event_info);
public:
	List(UILayout parent);
	void addItem(ListItem * item);
};
