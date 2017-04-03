/*
 * Window.h
 *
 *  Created on: Mar 15, 2017
 *      Author: YJK(Code.S), JYH(Code.S)
 */

#ifndef __basicui_H__
#define __basicui_H__

#pragma once

#include "RootObj.h"

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include "layout/UILayout.h"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "basicui"

#if !defined(PACKAGE)
#define PACKAGE "org.example.basicui"
#endif

#endif /* __basicui_H__ */

//

class Window:public UILayout{

private:
	static Window * mChildPointer;

private:
	static bool static_app_create(void *data);
	static void static_app_control(app_control_h app_control, void *data);
	static void static_app_pause(void *data);
	static void static_app_resume(void *data);
	static void static_app_terminate(void *data);
	static void static_ui_app_lang_changed(app_event_info_h event_info, void *user_data);
	static void static_ui_app_orient_changed(app_event_info_h event_info, void *user_data);
	static void static_ui_app_region_changed(app_event_info_h event_info, void *user_data);
	static void static_ui_app_low_battery(app_event_info_h event_info, void *user_data);
	static void static_ui_app_low_memory(app_event_info_h event_info, void *user_data);

protected:
	static void win_delete_request_cb(void *data, Evas_Object *obj, void *event_info);
	static void	win_back_cb(void *data, Evas_Object *obj, void *event_info);

	virtual bool app_create(void *data);
	virtual void app_control(app_control_h app_control, void *data);
	virtual void app_pause(void *data);
	virtual void app_resume(void *data);
	virtual void app_terminate(void *data);
	virtual void ui_app_lang_changed(app_event_info_h event_info, void *user_data);
	virtual void ui_app_orient_changed(app_event_info_h event_info, void *user_data);
	virtual void ui_app_region_changed(app_event_info_h event_info, void *user_data);
	virtual void ui_app_low_battery(app_event_info_h event_info, void *user_data);
	virtual void ui_app_low_memory(app_event_info_h event_info, void *user_data);

	virtual void onCreate();
	virtual void add(RootObj obj);

	void setVertical();
	void setHorizontal();
	void setRotation(bool option);

public:
	int makeWindow(int argc, char *argv[]);
};
