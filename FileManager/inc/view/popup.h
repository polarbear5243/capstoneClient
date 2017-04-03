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

#ifndef POPUP_H_
#define POPUP_H_

#include "view/view.h"
#include <Elementary.h>

typedef enum {
	POPUP_TYPE_DELETE,
	POPUP_TYPE_COPY_MOVE,
	POPUP_TYPE_NEW_FOLDER,
	POPUP_TYPE_FILE_EXISTS,
	POPUP_TYPE_WRONG_FILE_NAME,
	POPUP_TYPE_FAIL_TO_MOVE,
	POPUP_TYPE_MOVE_RECURSIVE_FAIL,
	POPUP_TYPE_FAIL_TO_COPY,
	POPUP_TYPE_COPY_RECURSIVE_FAIL,
	POPUP_TYPE_ERROR
} popup_type;

/**
 * @brief Creates and shows popup depending on popup type
 * @param[in]   view     View data
 * @param[in]   type     Popup type
 * @return Error code. RESULT_TYPE_OK if operation success.
 */
int popup_create(view_data *view, popup_type type);

#endif /* POPUP_H_ */
