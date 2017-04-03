/*
 * Copyright (c) 2015 Samsung Electronics Co., Ltd All Rights Reserved
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *
 */

#include "main.h"

/*
 * @brief Function will be operated when list item is selected.
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
list_selected_cb(void *data, Evas_Object *obj, void *event_info)
{
	Elm_Object_Item *it = event_info;
	elm_list_item_selected_set(it, EINA_FALSE);
}

/*
 * @brief Function to create list object
 * @param[in] nf The naviframe object which is list object is created on
 * @param[out] Evas_Object* The Evas object which is created
 */
static Evas_Object*
create_list(Evas_Object *nf)
{
	Evas_Object *list;

	/* List */
	list = elm_list_add(nf);
	elm_list_mode_set(list, ELM_LIST_COMPRESS);
	evas_object_smart_callback_add(list, "selected", list_selected_cb, NULL);
	elm_list_item_append(list, "Font Sizes", NULL, NULL, label_font_sizes_cb, nf);
	elm_list_item_append(list, "Linebreakmodes", NULL, NULL, label_linebreak_modes_cb, nf);
	elm_list_item_append(list, "Color Styles", NULL, NULL, label_color_styles_cb, nf);
	elm_list_item_append(list, "Ellipsis", NULL, NULL, label_ellipsis_cb, nf);
	elm_list_item_append(list, "Slide Text", NULL, NULL, label_slide_cb, nf);

	elm_list_go(list);

	return list;
}

/*
 * @brief Function will be operated when main menu "Label" is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
void
label_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *list;
	Evas_Object *nf = data;

	/* List */
	list = create_list(nf);
	elm_naviframe_item_push(nf, "Label", NULL, NULL, list, NULL);
}
