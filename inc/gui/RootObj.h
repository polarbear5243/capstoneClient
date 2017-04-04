/*
 * RootObj.h
 *
 *  Created on: Mar 16, 2017
 *      Author: YJK
 */
#pragma once

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <string>

class RootObj {

protected:
	Evas_Object * mContent;

public:
	RootObj();
	virtual ~RootObj();
	Evas_Object * getContent();
	void getGeometry(Evas_Coord *x, Evas_Coord *y, Evas_Coord *w, Evas_Coord *h) EINA_ARG_NONNULL(1);
	void setWeightHint(float width, float height);
	void setAlignHint(float width, float height);
	void setMinHint(float width, float height);
	void setMaxHint(float width, float height);
	void setEnable();
	void setDisable();
	void addCallback(Evas_Callback_Type type, Evas_Object_Event_Cb func, const void *data) EINA_ARG_NONNULL(1, 3);
	void setContent(std::string part, RootObj obj);
	void setStyle(std::string style);
	void show();
};
