#----------------------------------------------------------------
# Generated CMake target import file.
#----------------------------------------------------------------

# Commands may need to know the format version.
set(CMAKE_IMPORT_FILE_VERSION 1)

# Import target "rpclib::AirsimWrapper" for configuration ""
set_property(TARGET rpclib::AirsimWrapper APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(rpclib::AirsimWrapper PROPERTIES
  IMPORTED_COMMON_LANGUAGE_RUNTIME_NOCONFIG ""
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/lib/AirsimWrapper.bundle/Contents/MacOS/AirsimWrapper"
  IMPORTED_NO_SONAME_NOCONFIG "TRUE"
  )

list(APPEND _IMPORT_CHECK_TARGETS rpclib::AirsimWrapper )
list(APPEND _IMPORT_CHECK_FILES_FOR_rpclib::AirsimWrapper "${_IMPORT_PREFIX}/lib/AirsimWrapper.bundle/Contents/MacOS/AirsimWrapper" )

# Commands beyond this point should not need to know the version.
set(CMAKE_IMPORT_FILE_VERSION)
