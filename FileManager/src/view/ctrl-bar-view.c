/*
 * Copyright 2014 - 2015 Samsung Electronics Co., Ltd All Rights Reserved
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

#include "view/ctrl-bar-view.h"
#include "view/list-view.h"
#include "view/popup.h"
#include "view/window.h"
#include "utils/config.h"
#include "utils/logger.h"
#include "utils/app-types.h"
#include "main-app.h"
#include "model/clipboard.h"

#include <app.h>
#include <efl_extension.h>

#define FM_CTXPOPUP_HEIGHT ELM_SCALE_SIZE(80)
#define FM_CTXPOPUP_WIDTH  ELM_SCALE_SIZE(140)
#define FM_CTXPOPUP_TEXT_PASTE  "Paste Here"
#define FM_CTXPOPUP_TEXT_CREATE "Create New Folder"

#define FM_TOOLBAR_TEXT_EDIT    "EDIT"
#define FM_TOOLBAR_TEXT_MORE    "MORE"
#define FM_TOOLBAR_TEXT_EXIT    "EXIT"

#define FM_TOOLBAR_TEXT_DELETE  "DELETE"
#define FM_TOOLBAR_TEXT_MOVE    "MOVE"
#define FM_TOOLBAR_TEXT_COPY    "COPY"
#define FM_TOOLBAR_TEXT_CANCEL  "CANCEL"

static int _ctrl_bar_widget_fill(ctrl_bar_widget *widget);
static void _ctrl_bar_widget_add_update_buttons(ctrl_bar_widget *widget);
static void _ctrl_bar_widget_btns_state_update(ctrl_bar_widget *widget);
static void _ctrl_bar_widget_destroy(ctrl_bar_widget *data);

static void _ctrl_bar_widget_delete_cb(void *data, Evas *e, Evas_Object *obj, void *event_info);
static void _ctrl_bar_widget_edit_btn_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _ctrl_bar_widget_more_btn_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _ctrl_bar_widget_delete_btn_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _ctrl_bar_widget_move_btn_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _ctrl_bar_widget_copy_btn_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _ctrl_bar_widget_cancel_btn_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _ctrl_bar_widget_exit_btn_cb(void *data, Evas_Object *obj, void *eventInfo);

static void _ctrl_bar_widget_ctxpopup_past_here_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _ctrl_bar_widget_ctxpopup_create_folder_cb(void *data, Evas_Object *obj, void *eventInfo);
static void _ctrl_bar_widget_ctxpopup_back_button_cb(void *data, Evas_Object *obj, void *event_info);

ctrl_bar_widget *ctrl_bar_widget_add(view_data *view)
{
	RETVM_IF(!view, NULL, "View object is NULL");

	ctrl_bar_widget *data = calloc(1, sizeof(ctrl_bar_widget));
	RETVM_IF(!data, NULL, "Fail allocate memory");

	data->view = view;
	data->ctxpopup = NULL;

	if (_ctrl_bar_widget_fill(data) != RESULT_TYPE_OK) {
		ERR("Fail to initialise ctrl bar");
		_ctrl_bar_widget_destroy(data);
		return NULL;
	}

	evas_object_event_callback_add(data->ctrl_bar, EVAS_CALLBACK_FREE, _ctrl_bar_widget_delete_cb, data);

	return data;
}

int ctrl_bar_widget_mode_update(ctrl_bar_widget *widget)
{
	RETVM_IF(!widget, RESULT_TYPE_FAIL, "Widget object is NULL");
	RETVM_IF(!widget->view, RESULT_TYPE_FAIL, "View object is NULL");
	RETVM_IF(!widget->ctrl_bar, RESULT_TYPE_FAIL, "Ctrl bar object is NULL");

	_ctrl_bar_widget_add_update_buttons(widget);

	return RESULT_TYPE_OK;
}

int ctrl_bar_widget_state_update(ctrl_bar_widget *widget)
{
	RETVM_IF(!widget, RESULT_TYPE_FAIL, "Widget object is NULL");
	RETVM_IF(!widget->view, RESULT_TYPE_FAIL, "View object is NULL");
	RETVM_IF(!widget->ctrl_bar, RESULT_TYPE_FAIL, "Ctrl bar object is NULL");

	_ctrl_bar_widget_btns_state_update(widget);

	return RESULT_TYPE_OK;
}

static int _ctrl_bar_widget_fill(ctrl_bar_widget *widget)
{
	widget->ctrl_bar = elm_toolbar_add(widget->view->navi_layout);
	RETVM_IF(!widget->ctrl_bar, RESULT_TYPE_INVALID_ARG, "Ctrl bar object is NULL");

	elm_object_focus_set(widget->ctrl_bar, EINA_FALSE);
	elm_toolbar_shrink_mode_set(widget->ctrl_bar, ELM_TOOLBAR_SHRINK_EXPAND);
	elm_toolbar_transverse_expanded_set(widget->ctrl_bar, EINA_TRUE);

	elm_toolbar_select_mode_set(widget->ctrl_bar, ELM_OBJECT_SELECT_MODE_NONE);

	evas_object_size_hint_weight_set(widget->ctrl_bar, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(widget->ctrl_bar, EVAS_HINT_FILL, EVAS_HINT_FILL);

	elm_object_item_part_content_set(widget->view->navi_item, "toolbar", widget->ctrl_bar);

	_ctrl_bar_widget_add_update_buttons(widget);

	return RESULT_TYPE_OK;
}

static void _ctrl_bar_widget_add_update_buttons(ctrl_bar_widget *widget)
{
	app_data *app = widget->view->app;
	if (app->status.is_mainview || widget->view->is_root) {
		elm_toolbar_item_append(widget->ctrl_bar, NULL, "EXIT", _ctrl_bar_widget_exit_btn_cb, widget);
	} else {
		app_data *app = widget->view->app;
		Elm_Object_Item *item_del = elm_toolbar_first_item_get(widget->ctrl_bar);
		if (item_del) {
			Elm_Object_Item *item = elm_toolbar_item_next_get(item_del);
			while (item_del) {
				elm_object_item_del(item_del);
				item_del = item;
				item = elm_toolbar_item_next_get(item_del);
			}
		}

		if (app->status.curr_mode == MODE_DEFAULT) {
			Elm_Object_Item *edit_item = elm_toolbar_item_append(widget->ctrl_bar, NULL, FM_TOOLBAR_TEXT_EDIT, _ctrl_bar_widget_edit_btn_cb, widget);
			elm_toolbar_item_append(widget->ctrl_bar, NULL, FM_TOOLBAR_TEXT_MORE, _ctrl_bar_widget_more_btn_cb, widget);
			elm_toolbar_item_append(widget->ctrl_bar, NULL, FM_TOOLBAR_TEXT_EXIT, _ctrl_bar_widget_exit_btn_cb, widget);

			if (list_view_items_count_get(widget->view) < 1) {
				elm_object_item_disabled_set(edit_item, EINA_TRUE);
			}
		} else if (app->status.curr_mode == MODE_EDIT) {
			elm_toolbar_item_append(widget->ctrl_bar, NULL, FM_TOOLBAR_TEXT_DELETE, _ctrl_bar_widget_delete_btn_cb, widget);
			elm_toolbar_item_append(widget->ctrl_bar, NULL, FM_TOOLBAR_TEXT_MOVE, _ctrl_bar_widget_move_btn_cb, widget);
			elm_toolbar_item_append(widget->ctrl_bar, NULL, FM_TOOLBAR_TEXT_COPY, _ctrl_bar_widget_copy_btn_cb, widget);
			elm_toolbar_item_append(widget->ctrl_bar, NULL, FM_TOOLBAR_TEXT_CANCEL, _ctrl_bar_widget_cancel_btn_cb, widget);
		}
	}
}

static void _ctrl_bar_widget_btns_state_update(ctrl_bar_widget *widget)
{
	Eina_Bool disabled = (widget->view->edit.checked_count > 0) ? EINA_FALSE
																: EINA_TRUE;
	Elm_Object_Item *item = elm_toolbar_first_item_get(widget->ctrl_bar);
	Elm_Object_Item *last_item = elm_toolbar_last_item_get(widget->ctrl_bar);
	while (item != last_item) {
		elm_object_item_disabled_set(item, disabled);
		item = elm_toolbar_item_next_get(item);
	}
}

static void _ctrl_bar_widget_destroy(ctrl_bar_widget *data)
{
	free(data);
}

static void _ctrl_bar_widget_ctxpopup_back_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	ctrl_bar_widget *widget = data;
	evas_object_del(widget->ctxpopup);
	widget->ctxpopup = NULL;
}

static void _ctrl_bar_create_context_popup(ctrl_bar_widget *widget)
{
	app_data *app = widget->view->app;

	widget->ctxpopup = elm_ctxpopup_add(widget->view->navi);

	eext_object_event_callback_add(widget->ctxpopup,
			EEXT_CALLBACK_BACK,
			_ctrl_bar_widget_ctxpopup_back_button_cb,
			widget);

	evas_object_smart_callback_add(widget->ctxpopup,
			"dismissed",
			_ctrl_bar_widget_ctxpopup_back_button_cb,
			widget);

	RETM_IF(!widget->ctxpopup, "Fail to create ctxpopup");

	Eina_Bool is_cb_empty = EINA_TRUE;
	clipboard_is_empty(app->clipboard, &is_cb_empty);

	if (!is_cb_empty) {
		elm_ctxpopup_item_append(widget->ctxpopup, FM_CTXPOPUP_TEXT_PASTE, NULL, _ctrl_bar_widget_ctxpopup_past_here_cb, widget);
	}

	elm_ctxpopup_item_append(widget->ctxpopup, FM_CTXPOPUP_TEXT_CREATE, NULL, _ctrl_bar_widget_ctxpopup_create_folder_cb, widget);

	evas_object_size_hint_min_set(widget->ctxpopup, FM_CTXPOPUP_WIDTH, FM_CTXPOPUP_HEIGHT);

	int tb_height = 0;
	Evas_Object *tb = elm_object_part_content_get(widget->view->navi, "toolbar");

	if (tb) {
		evas_object_geometry_get(tb, NULL, NULL, NULL, &tb_height);
	} else {
		ERR("Toolbar is NULL");
	}

	int w = 0;
	int h = 0;
	evas_object_geometry_get(widget->view->app->win->win, NULL, NULL, &w, &h);
	evas_object_move(widget->ctxpopup, w / 2, h - tb_height);

	evas_object_show(widget->ctxpopup);
}

static void _ctrl_bar_widget_delete_cb(void *data, Evas *e, Evas_Object *obj, void *event_info)
{
	_ctrl_bar_widget_destroy(data);
}

static void _ctrl_bar_widget_edit_btn_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	ctrl_bar_widget *widget = data;
	widget->view->app->status.curr_mode = MODE_EDIT;

	int res = list_view_update(widget->view->navi_item,
			UPDATE_TYPE_GENLIST |
			UPDATE_TYPE_CTRL_BAR_MODE |
			UPDATE_TYPE_CTRL_BAR_STATE);

	RETM_IF(res != RESULT_TYPE_OK, "Fail to update view");
}

static void _ctrl_bar_widget_cancel_btn_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	ctrl_bar_widget *widget = data;
	widget->view->app->status.curr_mode = MODE_DEFAULT;

	int res = list_view_update(widget->view->navi_item,
			UPDATE_TYPE_GENLIST |
			UPDATE_TYPE_CTRL_BAR_MODE);

	RETM_IF(res != RESULT_TYPE_OK, "Fail to update view");
}

static void _ctrl_bar_widget_exit_btn_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	ui_app_exit();
}

static void _ctrl_bar_widget_delete_btn_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	ctrl_bar_widget *widget = data;

	int res = popup_create(widget->view, POPUP_TYPE_DELETE);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to create popup");
	}

static void _ctrl_bar_widget_move_btn_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	ctrl_bar_widget *widget = data;
	widget->view->app->status.curr_mode = MODE_DEFAULT;

	int res = list_view_move_items(widget->view);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to move file");

	res = list_view_update(widget->view->navi_item, UPDATE_TYPE_GENLIST | UPDATE_TYPE_CTRL_BAR_MODE);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to update view");

	res = popup_create(widget->view, POPUP_TYPE_COPY_MOVE);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to create popup");
}

static void _ctrl_bar_widget_copy_btn_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	ctrl_bar_widget *widget = data;
	widget->view->app->status.curr_mode = MODE_DEFAULT;

	int res = list_view_copy_items(widget->view);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to copy file");

	res = list_view_update(widget->view->navi_item, UPDATE_TYPE_GENLIST | UPDATE_TYPE_CTRL_BAR_MODE);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to update view");

	res = popup_create(widget->view, POPUP_TYPE_COPY_MOVE);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to create popup");
}

static void _ctrl_bar_widget_ctxpopup_past_here_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	ctrl_bar_widget *widget = data;

	elm_ctxpopup_dismiss(widget->ctxpopup);

	int res = list_view_past_items(widget->view);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to past file");
}

static void _ctrl_bar_widget_ctxpopup_create_folder_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	ctrl_bar_widget *widget = data;

	elm_ctxpopup_dismiss(widget->ctxpopup);

	int res = popup_create(widget->view, POPUP_TYPE_NEW_FOLDER);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to create popup");
}

static void _ctrl_bar_widget_more_btn_cb(void *data, Evas_Object *obj, void *eventInfo)
{
	RETM_IF(!data, "Data is NULL");

	ctrl_bar_widget *widget = data;

	elm_ctxpopup_dismiss(widget->ctxpopup);

	_ctrl_bar_create_context_popup(widget);
}
