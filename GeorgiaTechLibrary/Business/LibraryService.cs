﻿using GeorgiaTechLibrary.Models;
using GeorgiaTechLibrary.Repository;

namespace GeorgiaTechLibrary.Business
{
    public class LibraryService
    {
        private readonly ILibraryRepository _libraryRepository;
        public LibraryService(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }
        public Task<Library> GetLibrary(string libraryId) => _libraryRepository.GetLibrary(libraryId);
    }
}
