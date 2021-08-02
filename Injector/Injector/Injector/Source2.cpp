#include <Windows.h>
#include <conio.h>

#include <iostream>
#include <string>

std::string chooseDLL()
{
	OPENFILENAME ofn;
	char fileName[MAX_PATH] = "";

	ZeroMemory(&ofn, sizeof(ofn));
	ofn.lStructSize = sizeof(OPENFILENAME);
	ofn.lpstrFile = (LPSTR)fileName;
	ofn.nMaxFile = MAX_PATH;
	if (GetOpenFileName(&ofn))
		return (fileName);
}

int main()
{
	std::string enter;

	std::cout << "DLL Injector. Press enter to choose DLL" << std::endl;

	std::string stringpath = chooseDLL();
	const char* dllPath = stringpath.c_str();
	std::cout << "Injecting [" << dllPath << "]" << std::endl;


	DWORD pID;
	GetWindowThreadProcessId(FindWindowA(NULL, "Among Us"), &pID);

	if (!pID)
	{
		MessageBoxA(NULL, "Couldn't Get Process ID. Check if Among Us is open", "Error", NULL);
	}

	HANDLE hProcess = OpenProcess(PROCESS_ALL_ACCESS, NULL, pID);

	if (hProcess == INVALID_HANDLE_VALUE)
	{
		MessageBoxA(NULL, "Couldn't Get Handle to Among Us", "Error", NULL);
	}

	void* allocmemory = VirtualAllocEx(hProcess, 0, MAX_PATH, MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

	WriteProcessMemory(hProcess, allocmemory, dllPath, MAX_PATH, 0);

	HANDLE hThread = CreateRemoteThread(hProcess, 0, 0, (LPTHREAD_START_ROUTINE)LoadLibraryA, allocmemory, 0, 0);

	if (hThread)
	{
		MessageBoxA(NULL, "Injected Successfully", "Success", NULL);
		VirtualFreeEx(hProcess, allocmemory, NULL, MEM_RELEASE);
		CloseHandle(hThread);
		CloseHandle(hProcess);
	}

	return 0;
}