//// Functions, don't use flag arguments
  // Bad
  void CreateFile(string name, bool temp)
  {
    if (temp)
    {
      fs.Create($"./temp/{name}");
    }
    else
    {
      fs.Create(name);
    }
  }
  // Good
  void CreateFile(string name)
  {
    fs.Create(name);
  }
  void CreateTempFile(string name)
  {
    CreateFile($"./temp/{name}");
  }
