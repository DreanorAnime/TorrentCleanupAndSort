# TorrentCleanupAndSort
Combines the cleanup and sort project into one

## Cleanup setup
Change your torrent config to allow the following: (TransmissionQT config) 

```json
{
    "rpc-enabled": true,
    "rpc-port": 9091,
    "rpc-username": "",
    "script-torrent-done-enabled": true,
    "script-torrent-done-filename": "INSERTYOURPATHHERE\\TorrentCleanup.exe",
}
```

## Sort setup
Configure the json file. All files will be looked up in the RootFolder
```json
{
  "RootFolder": "D:\\",
  "FileRegex": "\\[.*?\\]",
  "FolderRegex": "[^a-zA-Z ]",
  "FileFilter": "*.mkv"
}
```
