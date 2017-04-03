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
 * @brief Function will be operated when flipselector item is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
void
flipselector_item_select_cb(void *data, Evas_Object *obj, void *event_info)
{
	Elm_Object_Item *it;

	it = event_info;
	dlog_print(DLOG_INFO, LOG_TAG, "label of selected item is: %s", elm_object_item_text_get(it));
}

/*
 * @brief Function will be operated when "underflow" event is triggered on flipselector
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
void
flipselector_underflowed_cb(void *data, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_INFO, LOG_TAG, "underflow!");
}

/*
 * @brief Function will be operated when "overflow" event is triggered on flipselector
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
void
flipselector_overflowed_cb(void *data EINA_UNUSED, Evas_Object *obj, void *event_info)
{
	dlog_print(DLOG_INFO, LOG_TAG, "overflow!");
}

/*
 * @brief Function to create flipselector object
 * @param[in] nf The naviframe object which flipselector is created on
 * @param[out] Evas_Object* The Evas object which is created
 */
static Evas_Object*
create_flipselector(Evas_Object *nf)
{
	Evas_Object *flipselector;
	char buf[8];
	int i;

	/* Flipselector */
	flipselector = elm_flipselector_add(nf);
	evas_object_smart_callback_add(flipselector, "underflowed", flipselector_overflowed_cb, NULL);
	evas_object_smart_callback_add(flipselector, "overflowed", flipselector_underflowed_cb, NULL);
	evas_object_size_hint_weight_set(flipselector, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	for (i = 0; i <= 999; i++) {
		snprintf(buf, 8, "%u", i);
		elm_flipselector_item_append(flipselector, buf, flipselector_item_select_cb, NULL);
	}

	return flipselector;
}

/*
 * @brief Function will be operated when main menu "Flipselector" is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
void
flipselector_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *flipselector, *layout;
	Evas_Object *nf = data;

	/* Layout */
	layout = elm_layout_add(nf);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "white_bg_layout");

	/* Flipselector */
	flipselector = create_flipselector(layout);
	elm_object_part_content_set(layout, "elm.swallow.content", flipselector);

	elm_naviframe_item_push(nf, "Flipselector", NULL, NULL, layout, NULL);
}
