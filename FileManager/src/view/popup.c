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

#include "view/popup.h"
#include "view/list-view.h"
#include "utils/logger.h"
#include "utils/app-types.h"
#include "utils/config.h"
#include "utils/common-utils.h"
#include "main-app.h"

#include <efl_extension.h>

static const char *const POPUP_BTN_OK = "Ok";
static const char *const POPUP_BTN_RETRY = "Retry";
static const char *const POPUP_BTN_CANCEL = "Cancel";

static const char *const POPUP_TEXT_DELETE = "Selected nodes will be deleted. Are you sure?";
static const char *const POPUP_TEXT_COPY_MOVE = "Data saved in clipboard";
static const char *const POPUP_TEXT_FILE_EXISTS = "Folder already exists";
static const char *const POPUP_TEXT_CREATE_FOLDER_FAIL = "Fail to create folder";
static const char *const POPUP_TEXT_INCORRECT_NAME = "Empty folder name";
static const char *const POPUP_TEXT_NEW_FOLDER = "New Folder";
static const char *const POPUP_TEXT_TITLE_NEW_FOLDER = "Add new folder";
static const char *const POPUP_TEXT_EMPTY_EDIT_FIELD = "Enter the folder name";
static const char *const POPUP_TEXT_MOVE_ERROR = "Moving error";
static const char *const POPUP_TEXT_MOVE_RECURSIVE_ERROR = "Cannot move catalog into itself";
static const char *const POPUP_TEXT_COPY_ERROR = "Operation copy failed";
static const char *const POPUP_TEXT_COPY_RECURSIVE_ERROR = "Cannot copy catalog into itself";
static const char *const POPUP_TEXT_ERROR = "Operation failed";

static int _popup_delete_type_create(view_data *view);
static int _popup_copy_move_type_create(view_data *view);
static int _popup_new_folder_type_create(view_data *view, const char *folder_name);
static int _popup_incorrect_name_type_create(view_data *view);
static int _popup_copy_move_error_type_create(view_data *view, const char *error_text);
static int _popup_error_type_create(view_data *view);
static int _popup_create_folder_error_type_create(view_data *view, const char *folder_name, const char *error_text);

static Evas_Object *_popup_new(Evas_Object *parent, const char *text, const void *data);
static int _popup_button_add(Evas_Object *parent, const char *part, const char *btn_text, Evas_Smart_Cb btn_cb, void *cb_data);
static int _popup_editfield_add(Evas_Object *popup, const char *folder_name);

static void _popup_cancel_cb(void *data, Evas_Object *obj, void *event_info);
static void _popup_delete_ok_cb(void *data, Evas_Object *obj, void *event_info);
static void _popup_create_folder_ok_cb(void *data, Evas_Object *obj, void *event_info);
static void _popup_create_folder_error_ok_cb(void *data, Evas_Object *obj, void *event_info);
static void _popup_incorrect_name_ok_cb(void *data, Evas_Object *obj, void *event_info);
static void _popup_back_button_cb(void *data, Evas_Object *obj, void *event_info);

int popup_create(view_data *view, popup_type type)
{
	RETVM_IF(!view, RESULT_TYPE_INVALID_ARG, "View obj is NULL");

	int res = RESULT_TYPE_OK;

	switch (type) {
	case POPUP_TYPE_DELETE:
		res = _popup_delete_type_create(view);
		break;
	case POPUP_TYPE_COPY_MOVE:
		res = _popup_copy_move_type_create(view);
		break;
	case POPUP_TYPE_NEW_FOLDER:
		res = _popup_new_folder_type_create(view, POPUP_TEXT_NEW_FOLDER);
		break;
	case POPUP_TYPE_WRONG_FILE_NAME:
		res = _popup_incorrect_name_type_create(view);
		break;
	case POPUP_TYPE_FAIL_TO_MOVE:
		res = _popup_copy_move_error_type_create(view, POPUP_TEXT_MOVE_ERROR);
		break;
	case POPUP_TYPE_MOVE_RECURSIVE_FAIL:
		res = _popup_copy_move_error_type_create(view, POPUP_TEXT_MOVE_RECURSIVE_ERROR);
		break;
	case POPUP_TYPE_FAIL_TO_COPY:
		res = _popup_copy_move_error_type_create(view, POPUP_TEXT_COPY_ERROR);
		break;
	case POPUP_TYPE_COPY_RECURSIVE_FAIL:
		res = _popup_copy_move_error_type_create(view, POPUP_TEXT_COPY_RECURSIVE_ERROR);
		break;
	case POPUP_TYPE_ERROR:
		res = _popup_error_type_create(view);
		break;
	default:
		ERR("Incorrect popup type");
		res = RESULT_TYPE_FAIL;
		break;
	}

	return res;
}

static int _popup_delete_type_create(view_data *view)
{
	Evas_Object *popup = _popup_new(view->navi, POPUP_TEXT_DELETE, view);
	RETVM_IF(!popup, RESULT_TYPE_INVALID_ARG, "Fail to create popup");

	int res = _popup_button_add(popup, "button1", POPUP_BTN_OK, _popup_delete_ok_cb, popup);
	if (res != RESULT_TYPE_OK) {
		ERR("Fail to create button");
		evas_object_del(popup);
		return RESULT_TYPE_FAIL;
	}

	res = _popup_button_add(popup, "button2", POPUP_BTN_CANCEL, _popup_cancel_cb, popup);
	if (res != RESULT_TYPE_OK) {
		ERR("Fail to create button");
		evas_object_del(popup);
		return RESULT_TYPE_FAIL;
	}

	return RESULT_TYPE_OK;
}

static int _popup_copy_move_type_create(view_data *view)
{
	Evas_Object *popup = _popup_new(view->navi, POPUP_TEXT_COPY_MOVE, view);
	RETVM_IF(!popup, RESULT_TYPE_INVALID_ARG, "Fail to create popup");

	int res = _popup_button_add(popup, "button1", POPUP_BTN_OK, _popup_cancel_cb, popup);
	if (res != RESULT_TYPE_OK) {
		ERR("Fail to create button");
		evas_object_del(popup);
		return RESULT_TYPE_FAIL;
	}

	return RESULT_TYPE_OK;
}

static int _popup_new_folder_type_create(view_data *view, const char *folder_name)
{
	RETVM_IF(!folder_name, RESULT_TYPE_INVALID_ARG, "Folder name is NULL");

	Evas_Object *popup = _popup_new(view->navi, NULL, view);
	RETVM_IF(!popup, RESULT_TYPE_INVALID_ARG, "Fail to create popup");

	elm_object_part_text_set(popup, "title,text", POPUP_TEXT_TITLE_NEW_FOLDER);

	int res = _popup_editfield_add(popup, folder_name);
	RETVM_IF(res != RESULT_TYPE_OK, res, "Fail to add editfield");

	res = _popup_button_add(popup, "button1", POPUP_BTN_OK, _popup_create_folder_ok_cb, popup);
	if (res != RESULT_TYPE_OK) {
		ERR("Fail to create button");
		evas_object_del(popup);
		return RESULT_TYPE_FAIL;
	}

	res = _popup_button_add(popup, "button2", POPUP_BTN_CANCEL, _popup_cancel_cb, popup);
	if (res != RESULT_TYPE_OK) {
		ERR("Fail to create button");
		evas_object_del(popup);
		return RESULT_TYPE_FAIL;
	}

	return RESULT_TYPE_OK;
}

static int _popup_copy_move_error_type_create(view_data *view, const char *error_text)
{
	Evas_Object *popup = _popup_new(view->navi, error_text, view);
	RETVM_IF(!popup, RESULT_TYPE_INVALID_ARG, "Fail to create popup");

	int res = _popup_button_add(popup, "button1", POPUP_BTN_OK, _popup_cancel_cb, popup);
	if (res != RESULT_TYPE_OK) {
		ERR("Fail to create button");
		evas_object_del(popup);
		return RESULT_TYPE_FAIL;
	}

	return RESULT_TYPE_OK;
}

static int _popup_create_folder_error_type_create(view_data *view, const char *folder_name, const char *error_text)
{
	Evas_Object *popup = _popup_new(view->navi, error_text, view);
	RETVM_IF(!popup, RESULT_TYPE_INVALID_ARG, "Fail to create popup");

	int res = _popup_button_add(popup, "button1", POPUP_BTN_RETRY, _popup_create_folder_error_ok_cb, popup);
	if (res != RESULT_TYPE_OK) {
		ERR("Fail to create button");
		evas_object_del(popup);
		return RESULT_TYPE_FAIL;
	}

	res = _popup_button_add(popup, "button2", POPUP_BTN_CANCEL, _popup_cancel_cb, popup);
	if (res != RESULT_TYPE_OK) {
		ERR("Fail to create button");
		evas_object_del(popup);
		return RESULT_TYPE_FAIL;
	}

	evas_object_data_set(popup, "folder_name", folder_name);
	return res;
}

static int _popup_error_type_create(view_data *view)
{
	Evas_Object *popup = _popup_new(view->navi, POPUP_TEXT_ERROR, view);
	RETVM_IF(!popup, RESULT_TYPE_INVALID_ARG, "Fail to create popup");

	int res = _popup_button_add(popup, "button1", POPUP_BTN_OK, _popup_cancel_cb, popup);
	if (res != RESULT_TYPE_OK) {
		ERR("Fail to create button");
		evas_object_del(popup);
		return RESULT_TYPE_FAIL;
	}

	return RESULT_TYPE_OK;
}

static int _popup_incorrect_name_type_create(view_data *view)
{
	Evas_Object *popup = _popup_new(view->navi, POPUP_TEXT_INCORRECT_NAME, view);
	RETVM_IF(!popup, RESULT_TYPE_INVALID_ARG, "Fail to create popup");

	int res = _popup_button_add(popup, "button1", POPUP_BTN_OK, _popup_incorrect_name_ok_cb, popup);
	if (res != RESULT_TYPE_OK) {
		ERR("Fail to create button");
		evas_object_del(popup);
		return RESULT_TYPE_FAIL;
	}

	return RESULT_TYPE_OK;
}

static void _popup_back_button_cb(void *data, Evas_Object *obj, void *event_info)
{
	evas_object_del(obj);
}

static Evas_Object *_popup_new(Evas_Object *parent, const char *text, const void *data)
{
	Evas_Object *popup = elm_popup_add(parent);
	RETVM_IF(!popup, NULL, "Fail to create popup");

	elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 1.0);

	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, _popup_back_button_cb, NULL);

	elm_object_style_set(popup, "default");
	elm_object_text_set(popup, text);

	evas_object_data_set(popup, "view", data);
	evas_object_show(popup);

	return popup;
}

static int _popup_editfield_add(Evas_Object *popup, const char *folder_name)
{
	Evas_Object *editfield = elm_layout_add(popup);
	RETVM_IF(!editfield, RESULT_TYPE_FAIL, "Fail to create editfield");
	elm_layout_theme_set(editfield, "layout", "editfield", "singleline");
	evas_object_size_hint_align_set(editfield, EVAS_HINT_FILL, 0.0);
	evas_object_size_hint_weight_set(editfield, EVAS_HINT_EXPAND, 0.0);

	Evas_Object *entry = elm_entry_add(editfield);
	if (!entry) {
		ERR("Fail to create entry");
		evas_object_del(editfield);
		return RESULT_TYPE_FAIL;
	}
	evas_object_size_hint_weight_set(entry, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_entry_scrollable_set(entry, EINA_TRUE);
	elm_entry_single_line_set(entry, EINA_TRUE);
	elm_object_part_text_set(entry, "elm.guide", POPUP_TEXT_EMPTY_EDIT_FIELD);
	elm_object_part_text_set(entry, "elm.text", folder_name);
	elm_entry_cursor_end_set(entry);
	elm_object_focus_set(entry, EINA_TRUE);

	elm_object_part_content_set(editfield, "elm.swallow.content", entry);
	elm_object_content_set(popup, editfield);

	return RESULT_TYPE_OK;
}

static int _popup_button_add(Evas_Object *parent, const char *part, const char *btn_text, Evas_Smart_Cb btn_cb, void *cb_data)
{
	Evas_Object *btn = elm_button_add(parent);
	RETVM_IF(!btn, RESULT_TYPE_INVALID_ARG, "Fail to create button");

	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	elm_object_text_set(btn, btn_text);
	evas_object_smart_callback_add(btn, "clicked", btn_cb, cb_data);

	elm_object_part_content_set(parent, part, btn);

	return RESULT_TYPE_OK;
}

static void _popup_cancel_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Data is NULL");

	char *folder_name = evas_object_data_get(data, "folder_name");
	free(folder_name);

	evas_object_del(data);
}

static void _popup_delete_ok_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Data is NULL");

	view_data *view = evas_object_data_get(data, "view");
	evas_object_del(data);

	view->app->status.curr_mode = MODE_DEFAULT;

	int res = list_view_delete_items(view);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to delete file");
}

static void _popup_create_folder_ok_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Data is NULL");

	Evas_Object *popup = data;
	view_data *view = evas_object_data_get(popup, "view");

	Evas_Object *editfield = elm_object_content_get(popup);
	Evas_Object *entry = elm_object_part_content_get(editfield, "elm.swallow.content");
	const char *folder_name = elm_entry_entry_get(entry);

	int res = RESULT_TYPE_OK;

	if (!folder_name || common_util_is_string_empty(folder_name)) {
		evas_object_del(data);
		res = _popup_incorrect_name_type_create(view);

		RETM_IF(res != RESULT_TYPE_OK, "Fail to create popup");
		return;
	}

	res = list_view_create_folder(view, folder_name);
	if (res != RESULT_TYPE_OK) {
		char *temp_name = strdup(folder_name);
		if (!temp_name) {
			ERR("Fail to allocate memory for current folder name");
			evas_object_del(data);
			return;
		}

		evas_object_del(data);

		const char *error_text = NULL;
		error_text = (res == RESULT_TYPE_DUPLICATED_NAME) ? POPUP_TEXT_FILE_EXISTS
														  : POPUP_TEXT_CREATE_FOLDER_FAIL;

		res = _popup_create_folder_error_type_create(view, temp_name, error_text);
		if (res != RESULT_TYPE_OK) {
			ERR("Fail to create popup");
			free(temp_name);
		}

		return;
	}

	res = list_view_update(view->navi_item, UPDATE_TYPE_VIEW | UPDATE_TYPE_CTRL_BAR_MODE);
	evas_object_del(data);

	RETM_IF(res != RESULT_TYPE_OK, "Fail to update view");
}

static void _popup_create_folder_error_ok_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Data is NULL");

	char *folder_name = evas_object_data_get(data, "folder_name");
	view_data *view = evas_object_data_get(data, "view");
	evas_object_del(data);

	int res = _popup_new_folder_type_create(view, folder_name);
	free(folder_name);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to create popup");
}

static void _popup_incorrect_name_ok_cb(void *data, Evas_Object *obj, void *event_info)
{
	RETM_IF(!data, "Data is NULL");

	view_data *view = evas_object_data_get(data, "view");
	evas_object_del(data);

	int res = _popup_new_folder_type_create(view, POPUP_TEXT_NEW_FOLDER);
	RETM_IF(res != RESULT_TYPE_OK, "Fail to create popup");
}

