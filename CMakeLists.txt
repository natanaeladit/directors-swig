set(PROJECT_NAME example)
cmake_minimum_required (VERSION 3.29)
project(${PROJECT_NAME})

add_library (${PROJECT_NAME} SHARED
    "main.cpp"
    "swig/interop.cpp"
)

include_directories(
    ${CMAKE_CURRENT_SOURCE_DIR}
    ${CMAKE_CURRENT_SOURCE_DIR}/swig
)

set_target_properties(${PROJECT_NAME} PROPERTIES PREFIX "")

target_link_libraries(
    ${PROJECT_NAME}
)