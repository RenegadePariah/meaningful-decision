#version 400 core

in vec2 position;

uniform mat4 transform;

out vec2 pass_pos;

void main(void){
	gl_Position = transform*vec4(position, 0.0, 1.0);
	pass_pos=vec2(position);
}