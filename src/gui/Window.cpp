/*
 * Window.cpp
 *
 *  Created on: Mar 15, 2017
 *      Author: YJK(Code.S), JYH(Code.S)
 */

#include "gui/Window.h"

Window * Window::mChildPointer;

//???
void Window::win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}
//????
void Window::win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	/* Let window go to hide state. */
	elm_win_lower((Evas_Object *)data);
}

bool Window::app_create(void *data)
{
	mContent = (Evas_Object *)data;

	mContent = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(mContent, EINA_TRUE);

	evas_object_smart_callback_add(mContent, "delete,request", win_delete_request_cb, NULL);
//	eext_object_event_callback_add(mContent, EEXT_CALLBACK_BACK, win_back_cb, mContent);

	elm_win_indicator_mode_set(mContent, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(mContent, ELM_WIN_INDICATOR_OPAQUE);

	evas_object_show(mContent);

	this->onCreate();

	return true;
}
void Window::app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}
void Window::app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}
void Window::app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}
void Window::app_terminate(void *data)
{
	/* Release all resources. */

}
void Window::ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/

	int ret;
	char *language;

	ret = app_event_get_language(event_info, &language);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_event_get_language() failed. Err = %d.", ret);
		return;
	}

	if (language != NULL) {
		elm_language_set(language);
		free(language);
	}
}
void Window::ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}
void Window::ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}
void Window::ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}
void Window::ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

bool Window::static_app_create(void *data)
{
	return mChildPointer->app_create(data);
}
void Window::static_app_control(app_control_h app_control, void *data)
{
	mChildPointer->app_control(app_control,data);
}
void Window::static_app_pause(void *data)
{
	mChildPointer->app_pause(data);
}
void Window::static_app_resume(void *data)
{
	mChildPointer->app_resume(data);
}
void Window::static_app_terminate(void *data)
{
	mChildPointer->app_terminate(data);
}
void Window::static_ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	mChildPointer->ui_app_lang_changed(event_info,user_data);
}
void Window::static_ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	mChildPointer->ui_app_orient_changed(event_info,user_data);
}
void Window::static_ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	mChildPointer->ui_app_region_changed(event_info,user_data);
}
void Window::static_ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	mChildPointer->ui_app_low_battery(event_info,user_data);
}
void Window::static_ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	mChildPointer->ui_app_low_memory(event_info,user_data);
}

void Window::onCreate()
{

}
void Window::add(RootObj obj)
{
	elm_object_content_set(mContent,obj.getContent());
}
/*----------------------------------------------------------------------------
	* public
----------------------------------------------------------------------------*/
int Window::makeWindow(int argc, char *argv[]){
	void * ad = 0;
	int ret;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	dlog_print(DLOG_INFO,"abc","abc");

	mChildPointer = this;

	event_callback.create = static_app_create;
	event_callback.terminate = static_app_terminate;
	event_callback.pause = static_app_pause;
	event_callback.resume = static_app_resume;
	event_callback.app_control = static_app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, static_ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, static_ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, static_ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, static_ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, static_ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);

	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}
	return ret;
}
void Window::setVertical()
{
	elm_win_rotation_set(mContent,0);
}
void Window::setHorizontal()
{
	elm_win_rotation_set(mContent,90);
}
void Window::setRotation(bool a)
{
	if(a==false)
	{
		int rots[0] = {};
		elm_win_wm_rotation_available_rotations_set(mContent, (const int *)(&rots), 0);
		return;
	}
	if (elm_win_wm_rotation_supported_get(mContent)) {
		if(elm_win_rotation_get(mContent) == 0)
		{
			int rots[4] = { 0,90,180,270 };
			elm_win_wm_rotation_available_rotations_set(mContent, (const int *)(&rots), 4);
		}
		else
		{
			int rots[3] = {90,180,270};
			elm_win_wm_rotation_available_rotations_set(mContent, (const int *)(&rots), 3);
		}
	}
	return;
}
