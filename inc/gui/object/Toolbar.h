/*
 * Toolbar.h
 *
 *  Created on: Mar 31, 2017
 *      Author: BGKG
 */

#pragma once
#include <gui/layout/UILayout.h>
#include"Object.h"

class Toolbar : public Object{

private:

public:
	Toolbar(UILayout parent);
	Elm_Object_Item* getItemFirst();
	void appendItem(const char *icon, const char *label, Evas_Smart_Cb func, const void *data);
	void setShrinkMode(Elm_Toolbar_Shrink_Mode shrink_mode);
	void setTransverseExpanded(Eina_Bool transverse_expanded);
	void setSelectMode(Elm_Object_Select_Mode mode);
protected:

};
