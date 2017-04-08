#include"app/AppParser.h"
#include<string>
#include<vector>
using namespace std;

const string AppParser::delimiter = "///";
const string AppParser::endStr = "\r\n";

vector<string> AppParser::parsingMsg(string str){
	vector<string> result;
	int i=0;
	int start=0;
	while(i < str.length()){
		if(str.substr(i,delimiter.length()).compare(delimiter)==0){
			result.push_back(str.substr(start,i-start));
			i=i+delimiter.length()-1;
			start=i+1;
		}
		i++;
	}
	result.push_back(str.substr(start,str.length()-start));
	return result;
}

string AppParser::wrapMsg(vector<string> str){
	string result = "";
	for(int i=0;i<str.size()-1;i++)
		result = result + str[i] + delimiter;
	result = result + str[str.size()-1];
//	result = result + endStr;
	return result;
}
