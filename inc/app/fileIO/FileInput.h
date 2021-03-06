#pragma once
#include<fstream>
#include<string>
#include <sys/stat.h>
#include <unistd.h>

#define FILE_DEFULT_FOLDER "MyApp"
#define FILE_ROOT_FOLDER "/opt/usr/media"

using namespace std;

class FileInput{
private:
	ifstream * mFile;
	string mFilePath;

public:
	FileInput(string file);
	string read();
	void close();
	~FileInput();
};
