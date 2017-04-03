/*
 * popup.h
 *
 *  Created on: Mar 31, 2017
 *      Author: BGKG
 */

#pragma once
#include <gui/layout/UILayout.h>
#include"Object.h"
#include<string>

using namespace std;

class Popup : public Object{
private:
	static UILayout * mMyWin;
public:
	static void setPopWin(UILayout * parent);
private:
	static void callback_block_clicked(void *data, Evas_Object *obj, void *event_info);
	static void callback_dismissed(void *data, Evas_Object *obj, void *event_info);
	static void callback_timeout(void *data, Evas_Object *obj, void *event_info);
public:
	Popup();
	void setTimeout(double timeout);
protected:
	virtual void block_clicked();
	virtual void dismissed();
	virtual void timeout();
};
