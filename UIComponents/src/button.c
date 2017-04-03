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
 * @brief Function will be operated when button is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	int btn_num = (int)data;

	dlog_print(DLOG_INFO, LOG_TAG, "clicked event on Button:%d", btn_num);
}

/*
 * @brief Function will be operated when pressed event is triggered on button
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
btn_pressed_cb(void *data, Evas_Object *obj, void *event_info)
{
	elm_object_text_set(obj, "Pressed");
}

/*
 * @brief Function will be operated when unpressed event is triggered on button
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
static void
btn_unpressed_cb(void *data, Evas_Object *obj, void *event_info)
{
	elm_object_text_set(obj, "Default");
}

/*
 * @brief Function to create scroller object
 * @param[in] parent The Evas object which scroller object is created on
 * @param[out] Evas_Object* The scroller object which is created
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
 * @brief Function to create button view layout
 * @param[in] parent The Evas object which view layout is created on
 * @param[out] Evas_Object* The layout object which is created on
 */
static Evas_Object*
create_button_view(Evas_Object *parent)
{
	Evas_Object *layout, *btn, *img, *box, *box2;
	char buf[PATH_MAX];

	/* outer box */
	box = elm_box_add(parent);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box);

	/* default button */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "button_layout_1");

	btn = elm_button_add(box);
	elm_object_text_set(btn, "Default");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)0);
	evas_object_smart_callback_add(btn, "pressed", btn_pressed_cb, NULL);
	evas_object_smart_callback_add(btn, "unpressed", btn_unpressed_cb, NULL);
	evas_object_show(btn);

	elm_object_part_content_set(layout, "elm.swallow.content", btn);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* 2 default buttons */

	/* inner box */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "button_layout_box");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);

	box2 = elm_box_add(box);
	elm_box_padding_set(box2, ELM_SCALE_SIZE(16), ELM_SCALE_SIZE(0));
	elm_box_horizontal_set(box2, EINA_TRUE);
	evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box2);

	/* button 1 */
	btn = elm_button_add(box2);
	elm_object_text_set(btn, "Default");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)1);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 2 */
	btn = elm_button_add(box2);
	elm_object_text_set(btn, "Disabled");
	elm_object_disabled_set(btn, EINA_TRUE);
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)2);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	elm_object_part_content_set(layout, "elm.swallow.content", box2);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* 3 text buttons */

	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "button_layout_box");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);

	/* inner box */
	box2 = elm_box_add(box);
	elm_box_padding_set(box2, ELM_SCALE_SIZE(16), ELM_SCALE_SIZE(0));
	elm_box_horizontal_set(box2, EINA_TRUE);
	evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box2);

	/* button 1 */
	btn = elm_button_add(box2);
	elm_object_text_set(btn, "Button");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)3);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 2 */
	btn = elm_button_add(box2);
	elm_object_text_set(btn, "Button");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)4);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 3 */
	btn = elm_button_add(box2);
	elm_object_text_set(btn, "Disabled");
	elm_object_disabled_set(btn, EINA_TRUE);
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)5);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	elm_object_part_content_set(layout, "elm.swallow.content", box2);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* 3 icon buttons */

	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "button_layout_box");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);

	/* inner box */
	box2 = elm_box_add(box);
	elm_box_padding_set(box2, ELM_SCALE_SIZE(16), ELM_SCALE_SIZE(0));
	elm_box_horizontal_set(box2, EINA_TRUE);
	evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box2);

	/* button 1 */
	btn = elm_button_add(box2);
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)6);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 1 image */
	img = elm_image_add(btn);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_call.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_object_part_content_set(btn, "icon", img);

	/* button 2 */
	btn = elm_button_add(box2);
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)7);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 2 image */
	img = elm_image_add(btn);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_email.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_object_part_content_set(btn, "icon", img);

	/* button 3 */
	btn = elm_button_add(box2);
	elm_object_disabled_set(btn, EINA_TRUE);
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)8);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 3 image */
	img = elm_image_add(btn);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_note.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_object_part_content_set(btn, "icon", img);

	elm_object_part_content_set(layout, "elm.swallow.content", box2);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* 2 icon + text buttons */

	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "button_layout_box");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);

	/* inner box */
	box2 = elm_box_add(box);
	elm_box_padding_set(box2, ELM_SCALE_SIZE(16), ELM_SCALE_SIZE(0));
	elm_box_horizontal_set(box2, EINA_TRUE);
	evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box2);

	/* button 1 */
	btn = elm_button_add(box2);
	elm_object_text_set(btn, "Button");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)9);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 1 image */
	img = elm_image_add(btn);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_call.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_object_part_content_set(btn, "icon", img);

	/* button 2 */
	btn = elm_button_add(box2);
	elm_object_disabled_set(btn, EINA_TRUE);
	elm_object_text_set(btn, "Disabled");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)10);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 2 image */
	img = elm_image_add(btn);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_email.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_object_part_content_set(btn, "icon", img);

	elm_object_part_content_set(layout, "elm.swallow.content", box2);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* 4 circle buttons */

	/* inner box */
	box2 = elm_box_add(box);
	elm_box_horizontal_set(box2, EINA_TRUE);
	evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box2);

	elm_box_pack_end(box, box2);

	/* button 1 */
	btn = elm_button_add(box2);
	elm_object_style_set(btn, "circle");
	elm_object_text_set(btn, "Phone");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)11);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, 0.5, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 1 image */
	img = elm_image_add(btn);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_call.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_object_part_content_set(btn, "icon", img);

	/* button 2 */
	btn = elm_button_add(box2);
	elm_object_style_set(btn, "circle");
	elm_object_text_set(btn, "Email");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)12);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, 0.5, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 2 image */
	img = elm_image_add(btn);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_email.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_object_part_content_set(btn, "icon", img);

	/* button 3 */
	btn = elm_button_add(box2);
	elm_object_style_set(btn, "circle");
	elm_object_text_set(btn, "Note");
	elm_object_disabled_set(btn, EINA_TRUE);
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)13);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, 0.5, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 3 image */
	img = elm_image_add(btn);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_note.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_object_part_content_set(btn, "icon", img);

	/* button 4 */
	btn = elm_button_add(box2);
	elm_object_style_set(btn, "circle");
	elm_object_text_set(btn, "More");
	elm_object_disabled_set(btn, EINA_TRUE);
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)14);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, 0.5, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 4 image */
	img = elm_image_add(btn);
	snprintf(buf, sizeof(buf), "%s/contacts_circle_btn_ic_more.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_object_part_content_set(btn, "icon", img);

	/* 1 bottom button */

	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "button_layout_bottom");

	btn = elm_button_add(box);
	elm_object_style_set(btn, "bottom");
	elm_object_text_set(btn, "Bottom");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)15);
	evas_object_show(btn);

	elm_object_part_content_set(layout, "elm.swallow.content", btn);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* 2 bottom buttons */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "button_layout_box_bottom");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);

	/* inner box */
	box2 = elm_box_add(box);
	elm_box_padding_set(box2, ELM_SCALE_SIZE(32), ELM_SCALE_SIZE(0));
	elm_box_horizontal_set(box2, EINA_TRUE);
	evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box2);

	/* button 1 */
	btn = elm_button_add(box2);
	elm_object_style_set(btn, "bottom");
	elm_object_text_set(btn, "Bottom");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)16);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 2 */
	btn = elm_button_add(box2);
	elm_object_style_set(btn, "bottom");
	elm_object_disabled_set(btn, EINA_TRUE);
	elm_object_text_set(btn, "Disabled");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)17);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	elm_object_part_content_set(layout, "elm.swallow.content", box2);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	/* 3 bottom buttons */
	layout = elm_layout_add(box);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "button_layout_box_bottom");
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, EVAS_HINT_FILL);

	/* inner box */
	box2 = elm_box_add(box);
	elm_box_padding_set(box2, ELM_SCALE_SIZE(32), ELM_SCALE_SIZE(0));
	elm_box_horizontal_set(box2, EINA_TRUE);
	evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box2);

	/* button 1 */
	btn = elm_button_add(box2);
	elm_object_style_set(btn, "bottom");
	elm_object_text_set(btn, "Bottom");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)18);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 2 */
	btn = elm_button_add(box2);
	elm_object_style_set(btn, "bottom");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)19);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, 0.5, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 2 image */
	img = elm_image_add(btn);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_call.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_object_part_content_set(btn, "icon", img);

	/* button 3 */
	btn = elm_button_add(box2);
	elm_object_style_set(btn, "bottom");
	elm_object_disabled_set(btn, EINA_TRUE);
	elm_object_text_set(btn, "Disabled");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void *)20);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL, 0.5);
	evas_object_show(btn);
	elm_box_pack_end(box2, btn);

	/* button 3 image */
	img = elm_image_add(btn);
	snprintf(buf, sizeof(buf), "%s/contacts_ic_circle_btn_email.png", ICON_DIR);
	elm_image_file_set(img, buf, NULL);
	elm_object_part_content_set(btn, "icon", img);

	elm_object_part_content_set(layout, "elm.swallow.content", box2);
	evas_object_show(layout);
	elm_box_pack_end(box, layout);

	return box;
}

/*
 * @brief Function will be operated when main menu "Button" is clicked
 * @param[in] data The data to be passed to the callback function
 * @param[in] obj The Evas object handle to be passed to the callback function
 * @param[in] event_info The system event information
 */
void
button_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *scroller, *layout, *box;
	Evas_Object *nf = data;

	scroller = create_scroller(nf);
	layout = elm_layout_add(scroller);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_layout_file_set(layout, ELM_DEMO_EDJ, "white_bg_layout");

	box = create_button_view(layout);
	elm_object_part_content_set(layout, "elm.swallow.content", box);
	elm_object_content_set(scroller, layout);

	elm_naviframe_item_push(nf, "Button", NULL, NULL, scroller, NULL);
}
