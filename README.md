# Newgrounds.io Save Cloud for Unity 2019
Newgrounds Cloud add-on for the deprecated Josh Tuttle's Newgrounds for Unity. Compatible with Unity 2019

## Why did you do this ?
My game [Pad of Time](https://www.padoftime.com "Pad of Time") was finished with Unity 2019, and unfortunately Newgrounds.io doesn't support it for Save Cloud.

## How to use it
Get the old Newgrounds.io package from here: [https://bitbucket.org/newgrounds/newgrounds.io-for-unity-c/](https://bitbucket.org/newgrounds/newgrounds.io-for-unity-c/ "https://bitbucket.org/newgrounds/newgrounds.io-for-unity-c/")

And merge it with the files of this repo. 

Example of how to save a string of data into the cloud: 
```csharp
    core _api;
	
    public void Save(string savedata)
    {
        setData saveRequest = new setData();
        saveRequest.id = 1;
        saveRequest.data = savedata;
        saveRequest.callWith(_api,
            (response) =>
            {
                if (response.success)
                {
                    //CloudSave - Saving success;
                }
                else
                {
                    //CloudSave - Saving failed
                }
            }
        );
    }
```

Example of how to load a string from the cloud: 

```csharp
    core _api;

    public void Load(string defaultSaveData,Action<string> result)
    {
        loadSlot loadCloud = new loadSlot();
        loadCloud.id = 1;
        loadCloud.app_id = _api.app_id;
        loadCloud.callWith(_api,
            (response) =>
            {
                if (response.success)
                {
                    //CloudSave - Reading success
                    if (!string.IsNullOrEmpty(response.slot.url))
                        StartCoroutine(LoadURL(response.slot.url, defaultSaveData, result));
                    else
                    {
                        //CloudSave - .sav url is invalid
                        result.Invoke(defaultSaveData);
                    }
                }
                else
                {
                    //CloudSave - Reading failed
                    result.Invoke(defaultSaveData);
                }
            }
        );
    }

    private IEnumerator LoadURL(string URL,string defaultResponse,Action<string> result)
    {
        using (UnityWebRequest getRequest = UnityWebRequest.Get(URL))
        {
            yield return getRequest.SendWebRequest();

            if (getRequest.isNetworkError)
            {
                //CloudSave - read .sav Network Error
                result.Invoke(defaultResponse);
            }

            if (getRequest.isDone)
            {
                //CloudSave - read .sav completed
                result.Invoke(getRequest.downloadHandler.text);
            }

        }
    }
```

You could check more info at [Newgrounds.io](https://www.newgrounds.io/ "Newgrounds.io ")