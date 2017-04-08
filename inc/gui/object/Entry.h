/*
 * Entry.h
 *
 *  Created on: Mar 23, 2017
 *      Author: YJK
 */
#pragma once
#include <gui/layout/UILayout.h>
#include"Object.h"
#include<string>

using namespace std;

class Entry:public Object{

private:
	static void callback_change(void *data, Evas_Object *obj, void *event_info);

public:
	Entry(UILayout parent);
	string getText();
	void setText(string str);
	void setEnable();
	void setDisable();
	Eina_Bool isEmpty();
	void setStyle(string str);
	void setPasswdMode();
	void unSetPasswdMode();
	void setSingleLine();
	void setMultLine();
	void clear();
	void setScrollable();
	void setUnScrollable();
	void setInputLayout(Elm_Input_Panel_Layout layout);
	void setInputReturnKeyTypeSet(Elm_Input_Panel_Return_Key_Type return_key_type);
protected:
	virtual void change();
};
