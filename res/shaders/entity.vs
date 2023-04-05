#version 400 core

in vec3 position;
in vec2 coordinate;

uniform mat4 transform;
uniform mat4 view;
uniform mat4 projection;

out vec2 pass_c;

void main(void){
    gl_Position=projection*view*transform*vec4(position,1.0);
    pass_c=coordinate;
}