/*
 * Copyright 2014 -2015 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

#include "view/navi-bar-title.h"
#include "view/navi-path-widget.h"
#include "view/list-view.h"
#include "view/navigator.h"
#include "utils/ui-utils.h"
#include "utils/model-utils.h"
#include "utils/app-types.h"
#include "utils/config.h"
#include "utils/logger.h"
#include "main-app.h"

void _navi_bar_title_widget_delete(title_widget *widget);
static Evas_Object *_navi_bar_title_create_button(title_widget *widget,
		Evas_Object *parent_layout,
		const char *icon_id,
		const char *part,
		Evas_Smart_Cb cb_clicked,
		Evas_Smart_Cb cb_pressed,
		Evas_Smart_Cb cb_unpressed);


void _navi_bar_title_widget_delete_cb(void *data, Evas *e, Evas_Object *obj,
		void *event_info);

static void _navi_bar_title_home_button_on_click_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _navi_bar_title_home_button_on_pressed_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _navi_bar_title_home_button_on_unpressed_cb(void *data, Evas_Object *obj, void *eventInfo);

static void _navi_bar_title_upper_button_on_click_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _navi_bar_title_upper_button_on_pressed_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _navi_bar_title_upper_button_on_unpressed_cb(void *data, Evas_Object *obj, void *eventInfo);

title_widget *navi_bar_title_widget_add(view_data *view)
{
	RETVM_IF(!view, NULL, "View is NULL");

	title_widget *data = calloc(1, sizeof(title_widget));
	RETVM_IF(!data, NULL, "Fail allocate memory");

	data->view = view;

	Evas_Object *btn = _navi_bar_title_create_button(data,
			data->view->navi_layout,
			ui_utils_get_resource(FM_TITLE_ICON_HOME),
			"title_left_btn",
			_navi_bar_title_home_button_on_click_cb,
			_navi_bar_title_home_button_on_pressed_cb,
			_navi_bar_title_home_button_on_unpressed_cb);

	if (!btn) {
		ERR("Fail to create home button");
		_navi_bar_title_widget_delete(data);
		return NULL;
	}

	elm_object_item_part_content_set(data->view->navi_item, "title_left_btn", btn);

	btn = _navi_bar_title_create_button(data,
			data->view->navi_layout,
			ui_utils_get_resource(FM_TITLE_ICON_UPPER),
			"title_right_btn",
			_navi_bar_title_upper_button_on_click_cb,
			_navi_bar_title_upper_button_on_pressed_cb,
			_navi_bar_title_upper_button_on_unpressed_cb);

	if (!btn) {
		ERR("Fail to create upper button");
		_navi_bar_title_widget_delete(data);
		return NULL;
	}

	elm_object_item_part_content_set(data->view->navi_item, "title_right_btn", btn);

	evas_object_event_callback_add(btn, EVAS_CALLBACK_FREE, _navi_bar_title_widget_delete_cb, data);

	return data;
}

void _navi_bar_title_widget_delete(title_widget *widget)
{
	free(widget);
}

void _navi_bar_title_widget_delete_cb(void *data, Evas *e, Evas_Object *obj,
		void *event_info)
{
	_navi_bar_title_widget_delete(data);
}

static Evas_Object *_navi_bar_title_create_button(title_widget *widget,
		Evas_Object *parent_layout,
		const char *icon_id,
		const char *part,
		Evas_Smart_Cb cb_clicked,
		Evas_Smart_Cb cb_pressed,
		Evas_Smart_Cb cb_unpressed)
{
	Evas_Object *btn = elm_object_part_content_get(parent_layout, part);
	if (!btn) {
		btn = elm_button_add(parent_layout);
		RETVM_IF(!btn, NULL, "btn is NULL");

		elm_object_style_set(btn, "naviframe/title_icon");

		Evas_Object *icon = elm_image_add(parent_layout);
		RETVM_IF(!icon, NULL, "Icon is NULL");

		elm_image_file_set(icon, icon_id, NULL);
		elm_image_resizable_set(icon, EINA_TRUE, EINA_TRUE);
		elm_object_content_set(btn, icon);
		evas_object_smart_callback_add(btn, "clicked"  , cb_clicked  , widget);
		evas_object_smart_callback_add(btn, "pressed"  , cb_pressed  , icon);
		evas_object_smart_callback_add(btn, "unpressed", cb_unpressed, icon);
		evas_object_show(btn);

		elm_object_part_content_set(parent_layout, part, btn);
	}

	return btn;
}

static void _navi_bar_title_home_button_on_click_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	title_widget *widget = data;
	app_data *app = widget->view->app;

	int res = navigator_goto_root_view(app->navigator);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to navigate to root view");

}

static void _navi_bar_title_home_button_on_pressed_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	Evas_Object *home_button_ic = data;
	elm_image_file_set(home_button_ic, ui_utils_get_resource(FM_TITLE_ICON_HOME_PRESS), NULL);
}

static void _navi_bar_title_home_button_on_unpressed_cb(void *data, Evas_Object *obj, void *eventInfo)
	{
	RETM_IF(!data, "Data is NULL");

	Evas_Object *home_button_ic = data;
	elm_image_file_set(home_button_ic, ui_utils_get_resource(FM_TITLE_ICON_HOME), NULL);
}

static void _navi_bar_title_upper_button_on_click_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	title_widget *widget = data;
	app_data *app = widget->view->app;

	int res = navigator_goto_previous_view(app->navigator);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to navigate to previous view");
}

static void _navi_bar_title_upper_button_on_pressed_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	Evas_Object *upper_button_ic = data;
	elm_image_file_set(upper_button_ic, ui_utils_get_resource(FM_TITLE_ICON_UPPER_PRESS), NULL);
}

static void _navi_bar_title_upper_button_on_unpressed_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	Evas_Object *upper_button_ic = data;
	elm_image_file_set(upper_button_ic, ui_utils_get_resource(FM_TITLE_ICON_UPPER), NULL);
}
