#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 2) in vec2 aTexCoord;

out vec3 ourColor;
out vec2 texCoord;

uniform mat4 transformMatrix;

void main() {
    gl_Position = transformMatrix * vec4(aPos, 1.0);
    texCoord = aTexCoord;
}