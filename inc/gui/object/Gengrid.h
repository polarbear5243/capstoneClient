/*
 * Gengrid.h
 *
 *  Created on: Apr 3, 2017
 *      Author: BGKG
 */
#pragma once
#include <gui/layout/UILayout.h>
#include"Object.h"

class Gengrid : public Object
{
private:
	static void callback_pressed(void *data, Evas_Object *obj, void *event_info);
	//Elm_Gengrid_Item_Class* itc;
public:
	Gengrid(UILayout parent);
	void setItemSize(Evas_Coord w, Evas_Coord h);
	void setAlign(double align_x, double align_y);
	void setHorizontal(Eina_Bool horizontal);
	void setMultiSelect(Eina_Bool multi);

protected:
	virtual void pressed();
};
