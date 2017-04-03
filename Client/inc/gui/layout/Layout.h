#ifndef GUI_LAYOUT_LAYOUT_H_
#define GUI_LAYOUT_LAYOUT_H_
#include <gui/layout/UILayout.h>
#include"../Window.h"
#include<string>

using namespace std;

class Layout:public UILayout{
protected:
	static string mEdcFilePath;

public :
	static void initEdcFile(string fileName);

public:
	Layout(UILayout parent);
	void setEDCfile(string group);
	void setTheme(string klass, string group, string style);
	//void setContent(string part, RootObj obj);
};

#endif /* GUI_LAYOUT_LAYOUT_H_ */
