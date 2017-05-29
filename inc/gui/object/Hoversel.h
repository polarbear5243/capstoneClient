#pragma once
#include <gui/layout/UILayout.h>

#include"Object.h"

#include <string>

using namespace std;

class Hoversel : public Object
{
private:
	static void callback_clicked(void *data, Evas_Object *obj, void *event_info);
	static void callback_selected(void *data, Evas_Object *obj, void *event_info);
	static void callback_dismissed(void *data, Evas_Object *obj, void *event_info);

public:
	Hoversel(UILayout parent);
	void setParent(Elm_Hoversel *obj, Evas_Object *parent);
	void addItem(string str);
	void setName(string str);
protected:
	virtual void clicked();
	virtual void selected();
	virtual void dismissed();
};
