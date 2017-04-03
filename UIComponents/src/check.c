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
 * @brief Function will be operated when check's value is changed
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
check_changed_cb(void *data, Evas_Object *obj, void *event_info)
{
	int check_num = (int)(data);

	Eina_Bool state = elm_check_state_get(obj);

	dlog_print(DLOG_INFO, LOG_TAG, "Check %d:%d", check_num, state);
}

/*
 * @brief Function to create scroller object
 * @param[in] parent The Evas object which scroller object is created on
 * @param[out] Evas_Object* The Evas object which is created
 */
static Evas_Object*
create_scroller(Evas_Object *parent)
{
	Evas_Object *scroller = elm_scroller_add(parent);
	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	evas_object_show(scroller);

	return scroller;
}

/*
 * @brief Function to create check layout
 * @param[in] parent The Evas object which check layout is created on
 * @param[out] Evas_Object* The Evas object is created on
 */
static Evas_Object*
create_checks(Evas_Object *parent)
{
	Evas_Object *layout;
	Evas_Object *check;
	Evas_Object *box;

	/* Box */
	box = elm_box_add(parent);
	elm_box_padding_set(box, ELM_SCALE_SIZE(10), ELM_SCALE_SIZE(10));
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box);

	/* Layout - default style check */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "check_layout");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, 0.5, 1);

	/* Check - default style */
	check = elm_check_add(layout);
	elm_object_text_set(check, "Default");
	elm_check_state_set(check, EINA_TRUE);
	evas_object_smart_callback_add(check, "changed", check_changed_cb, (void *)1);
	evas_object_show(check);

	elm_object_part_content_set(layout, "elm.swallow.content", check);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* Layout - disabled default style check */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "check_layout");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, 0.5, 1);

	/* Check - default style, disabled, state on */
	check = elm_check_add(box);
	elm_object_text_set(check, "Default");
	elm_check_state_set(check, EINA_TRUE);
	elm_object_disabled_set(check, EINA_TRUE);
	evas_object_smart_callback_add(check, "changed", check_changed_cb, (void *)1);
	evas_object_show(check);

	elm_object_part_content_set(layout, "elm.swallow.content", check);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* Layout - disabled default style check (off) */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "check_layout");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, 0.5, 1);

	/* Check - default style, disabled, state off */
	check = elm_check_add(box);
	elm_check_state_set(check, EINA_FALSE);
	elm_object_disabled_set(check, EINA_TRUE);
	evas_object_smart_callback_add(check, "changed", check_changed_cb, (void *)1);
	evas_object_show(check);

	elm_object_part_content_set(layout, "elm.swallow.content", check);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* Layout - favorite style check */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "check_layout");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, 0.5, 1);

	/* Check - favorite style */
	check = elm_check_add(box);
	elm_object_style_set(check, "favorite");
	elm_object_text_set(check, "Favorite");
	elm_check_state_set(check, EINA_FALSE);
	evas_object_smart_callback_add(check, "changed", check_changed_cb, (void *)2);
	evas_object_show(check);

	elm_object_part_content_set(layout, "elm.swallow.content", check);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* Layout - disabled favorite style check */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "check_layout");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, 0.5, 1);

	/* Check - favorite style, disabled, state on */
	check = elm_check_add(box);
	elm_object_style_set(check, "favorite");
	elm_object_text_set(check, "Favorite");
	elm_check_state_set(check, EINA_TRUE);
	elm_object_disabled_set(check, EINA_TRUE);
	evas_object_smart_callback_add(check, "changed", check_changed_cb, (void *)2);
	evas_object_show(check);

	elm_object_part_content_set(layout, "elm.swallow.content", check);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* Layout - disabled favorite style check (off) */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "check_layout");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, 0.5, 1);

	/* Check - favorite style, disabled, state off */
	check = elm_check_add(box);
	elm_object_style_set(check, "favorite");
	elm_atspi_accessible_name_set(check, "Favorite button");
	elm_check_state_set(check, EINA_FALSE);
	elm_object_disabled_set(check, EINA_TRUE);
	evas_object_smart_callback_add(check, "changed", check_changed_cb, (void *)2);
	evas_object_show(check);

	elm_object_part_content_set(layout, "elm.swallow.content", check);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* Layout - on&off style check */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "check_layout");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, 0.5, 1);

	/* Check - on&off style */
	check = elm_check_add(box);
	elm_object_style_set(check, "on&off");
	elm_object_text_set(check, "On&amp;Off");
	elm_check_state_set(check, EINA_TRUE);
	elm_atspi_accessible_role_set(check, ELM_ATSPI_ROLE_TOGGLE_BUTTON);
	evas_object_smart_callback_add(check, "changed", check_changed_cb, (void *)3);
	evas_object_show(check);

	elm_object_part_content_set(layout, "elm.swallow.content", check);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* Layout - disabled on&off style check */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "check_layout");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, 0.5, 1);

	/* Check - on&off style, disabled, state on */
	check = elm_check_add(box);
	elm_object_style_set(check, "on&off");
	elm_atspi_accessible_role_set(check, ELM_ATSPI_ROLE_TOGGLE_BUTTON);
	elm_object_text_set(check, "On&amp;Off");
	elm_check_state_set(check, EINA_TRUE);
	elm_object_disabled_set(check, EINA_TRUE);
	evas_object_smart_callback_add(check, "changed", check_changed_cb, (void *)3);
	evas_object_show(check);

	elm_object_part_content_set(layout, "elm.swallow.content", check);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* Layout - disabled on&off style check (off) */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "check_layout");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, 0.5, 1);

	/* Check - on&off style, disabled, state off */
	check = elm_check_add(box);
	elm_object_style_set(check, "on&off");
	elm_atspi_accessible_role_set(check, ELM_ATSPI_ROLE_TOGGLE_BUTTON);
	elm_atspi_accessible_name_set(check, "On, off");
	elm_check_state_set(check, EINA_FALSE);
	elm_object_disabled_set(check, EINA_TRUE);
	evas_object_smart_callback_add(check, "changed", check_changed_cb, (void *)3);
	evas_object_show(check);

	elm_object_part_content_set(layout, "elm.swallow.content", check);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	return box;
}

/*
 * @brief Function will be operated when main menu "Check" is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
void
check_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *scroller, *layout, *box;
	Evas_Object *nf = data;

	scroller = create_scroller(nf);
	layout = elm_layout_add(scroller);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "white_bg_layout");

	box = create_checks(layout);
	elm_object_part_content_set(layout, "elm.swallow.content", box);
	elm_object_content_set(scroller, layout);

	elm_naviframe_item_push(nf, "Check", NULL, NULL, scroller, NULL);
}
