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

#ifndef CTRL_BAR_VIEW_H_
#define CTRL_BAR_VIEW_H_

#include "view/view.h"
#include <Evas.h>

/**
 * @brief Control bar widget data
 */
typedef struct {
	view_data *view;                /**< Parent view */

	Evas_Object *ctrl_bar;          /**< Toolbar object */
	Evas_Object *ctxpopup;          /**< Ctxpopup object */
} ctrl_bar_widget;

/**
 * @brief Add new control bar widget to view
 * @param[in]   view      View object.
 * @return Control bar widget on success or NULL.
 */
ctrl_bar_widget *ctrl_bar_widget_add(view_data *view);

/**
 * @brief Updates control bar and recreates buttons depending on mode
 * @param[in]   widget   Widget object.
 * @return Error code. RESULT_TYPE_OK if operation success.
 */
int ctrl_bar_widget_mode_update(ctrl_bar_widget *widget);

/**
 * @brief Updates control bar buttons state
 * @param[in]   widget   Widget object.
 * @return Error code. RESULT_TYPE_OK if operation success.
 */
int ctrl_bar_widget_state_update(ctrl_bar_widget *widget);

#endif /* CTRL_BAR_VIEW_H_ */
