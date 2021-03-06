#pragma once
#include<fstream>
#include<string>
#include <sys/stat.h>
#include <unistd.h>

#define FILE_DEFULT_FOLDER "MyApp"
#define FILE_ROOT_FOLDER "/opt/usr/media"

using namespace std;

class FileOutput{
private:
	ofstream * mFile;
	string mFilePath;

public:
	FileOutput(string file);
	void writeln(string str);
	void write(string str);
	void close();
	~FileOutput();
};
