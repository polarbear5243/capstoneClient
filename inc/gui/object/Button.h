#pragma once
#include <gui/layout/UILayout.h>
#include <gui/object/TextStyle.h>
#include"Object.h"
#include<string>

using namespace std;

class Button:public Object{
protected:
	TextStyle mTextStyle;

private:
	static void callback_click(void *data, Evas_Object *obj, void *event_info);
	static void callback_pressed(void *data, Evas_Object *obj, void *event_info);
	static void callback_unpressed(void *data, Evas_Object *obj, void *event_info);

public:
	Button();
	Button(UILayout parent);
	void setText(string str);
	void setSize(string size);
	void setAlign(string align);
	void setColor(string color);

	void setStyle(string str);

protected:
	virtual void click();
	virtual void pressed();
	virtual void unpressed();
};

