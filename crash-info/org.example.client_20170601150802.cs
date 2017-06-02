S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 3110
Date: 2017-06-01 15:08:02+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 3110, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000c26
r2   = 0x00000006, r3   = 0xb41184c0
r4   = 0x00000002, r5   = 0xb4118000
r6   = 0xb681209c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f40708
r10  = 0xb81210f8, fp   = 0x80084a28
ip   = 0x00000000, sp   = 0xbe8f7eb4
lr   = 0xb6708f18, pc   = 0xb6707b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     69972 KB
Buffers:     77428 KB
Cached:     273096 KB
VmPeak:     135312 KB
VmSize:     135136 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29412 KB
VmRSS:       29412 KB
VmData:      47240 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35756 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3110 TID = 3110
3110 3111 3380 3381 3389 

Maps Information
af22e000 afa2d000 rw-p [stack:3389]
b13d5000 b13dd000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13ef000 b1bee000 rw-p [stack:3381]
b1bee000 b1bef000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bff000 b1c13000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c27000 b1c28000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c38000 b1c3b000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c4c000 b1c4d000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c5d000 b1c5f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c6f000 b1c71000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c81000 b1c91000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1ca1000 b1cad000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cbf000 b24be000 rw-p [stack:3380]
b27ef000 b27f6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2809000 b280f000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b281f000 b284b000 r-xp /opt/usr/apps/org.example.client/bin/client
b29a4000 b2a87000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2abe000 b2ae6000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2af8000 b32f7000 rw-p [stack:3111]
b32f7000 b32f9000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3309000 b3313000 r-xp /lib/libnss_files-2.20-2014.11.so
b3324000 b332d000 r-xp /lib/libnss_nis-2.20-2014.11.so
b333e000 b334f000 r-xp /lib/libnsl-2.20-2014.11.so
b3362000 b3368000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3379000 b337a000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33a2000 b33a9000 r-xp /usr/lib/libminizip.so.1.0.0
b33b9000 b33be000 r-xp /usr/lib/libstorage.so.0.1
b33ce000 b342d000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3443000 b3457000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3467000 b34ab000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34bb000 b34c3000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34d3000 b3503000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3516000 b35cf000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35e3000 b3636000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3647000 b3662000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3672000 b3733000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3746000 b3756000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3766000 b3773000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3784000 b378b000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b379b000 b37dc000 r-xp /usr/lib/libmdm.so.1.2.12
b37ec000 b37f4000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3803000 b3813000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3834000 b3894000 r-xp /usr/lib/libasound.so.2.0.0
b38a6000 b38a9000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38b9000 b38bc000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38cc000 b38d1000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38e1000 b38e2000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38f2000 b38fd000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3911000 b3918000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3928000 b392e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b393e000 b3943000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3953000 b396e000 r-xp /usr/lib/libmmfsound.so.0.1.0
b397e000 b3985000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3995000 b3998000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39a9000 b39d7000 r-xp /usr/lib/libidn.so.11.5.44
b39e7000 b39fd000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a0e000 b3a18000 r-xp /usr/lib/libcares.so.2.1.0
b3a28000 b3a32000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a42000 b3a44000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a54000 b3a55000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a65000 b3a69000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a7a000 b3aa2000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ab3000 b3adc000 r-xp /usr/lib/libturbojpeg.so
b3afc000 b3b02000 r-xp /usr/lib/libgif.so.4.1.6
b3b12000 b3b58000 r-xp /usr/lib/libcurl.so.4.3.0
b3b69000 b3b8a000 r-xp /usr/lib/libexif.so.12.3.3
b3ba5000 b3bba000 r-xp /usr/lib/libtts.so
b3bcb000 b3bd3000 r-xp /usr/lib/libfeedback.so.0.1.4
b3be3000 b3ca9000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cc9000 b3dc1000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3de0000 b3eae000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ec5000 b3ec7000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ed7000 b3edd000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eed000 b3f10000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f21000 b3f23000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f33000 b3f35000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f46000 b3f4b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f62000 b3f64000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f74000 b3f7b000 r-xp /usr/lib/libsensord-share.so
b3f8b000 b3fa3000 r-xp /usr/lib/libsensor.so.1.1.0
b3fb4000 b3fb7000 r-xp /usr/lib/libXv.so.1.0.0
b3fc7000 b3fcc000 r-xp /usr/lib/libutilX.so.1.1.0
b3fdc000 b3fe1000 r-xp /usr/lib/libappcore-common.so.1.1
b3ff1000 b3ff8000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b400b000 b400f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4020000 b40fe000 r-xp /usr/lib/libCOREGL.so.4.0
b411e000 b4121000 r-xp /usr/lib/libuuid.so.1.3.0
b4131000 b4148000 r-xp /usr/lib/libblkid.so.1.1.0
b4159000 b415b000 r-xp /usr/lib/libXau.so.6.0.0
b416b000 b41b2000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41c4000 b41ca000 r-xp /usr/lib/libjson-c.so.2.0.1
b41db000 b41df000 r-xp /usr/lib/libogg.so.0.7.1
b41ef000 b4211000 r-xp /usr/lib/libvorbis.so.0.4.3
b4221000 b4305000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4321000 b4324000 r-xp /usr/lib/libEGL.so.1.4
b4335000 b433b000 r-xp /usr/lib/libxcb-render.so.0.0.0
b434b000 b434d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b435d000 b436a000 r-xp /usr/lib/libGLESv2.so.2.0
b437b000 b43dd000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43f2000 b440a000 r-xp /usr/lib/libmount.so.1.1.0
b441c000 b4430000 r-xp /usr/lib/libxcb.so.1.1.0
b4440000 b4447000 r-xp /lib/libcrypt-2.20-2014.11.so
b447f000 b4481000 r-xp /usr/lib/libiri.so
b4491000 b449c000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44ad000 b44e3000 r-xp /usr/lib/libpulse.so.0.16.2
b44f4000 b4537000 r-xp /usr/lib/libsndfile.so.1.0.25
b454c000 b4561000 r-xp /lib/libexpat.so.1.5.2
b4573000 b4631000 r-xp /usr/lib/libcairo.so.2.11200.14
b4645000 b464d000 r-xp /usr/lib/libdrm.so.2.4.0
b465d000 b4660000 r-xp /usr/lib/libdri2.so.0.0.0
b4670000 b46be000 r-xp /usr/lib/libssl.so.1.0.0
b46d3000 b46df000 r-xp /usr/lib/libeeze.so.1.13.0
b46f0000 b46f9000 r-xp /usr/lib/libethumb.so.1.13.0
b4709000 b470c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b471c000 b48d3000 r-xp /usr/lib/libcrypto.so.1.0.0
b56be000 b56c7000 r-xp /usr/lib/libXi.so.6.1.0
b56d7000 b56d9000 r-xp /usr/lib/libXgesture.so.7.0.0
b56e9000 b56ed000 r-xp /usr/lib/libXtst.so.6.1.0
b56fd000 b5703000 r-xp /usr/lib/libXrender.so.1.3.0
b5713000 b5719000 r-xp /usr/lib/libXrandr.so.2.2.0
b5729000 b572b000 r-xp /usr/lib/libXinerama.so.1.0.0
b573c000 b573f000 r-xp /usr/lib/libXfixes.so.3.1.0
b574f000 b575a000 r-xp /usr/lib/libXext.so.6.4.0
b576a000 b576c000 r-xp /usr/lib/libXdamage.so.1.1.0
b577c000 b577e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b578e000 b5870000 r-xp /usr/lib/libX11.so.6.3.0
b5884000 b588b000 r-xp /usr/lib/libXcursor.so.1.0.2
b589b000 b58b3000 r-xp /usr/lib/libudev.so.1.6.0
b58b5000 b58b8000 r-xp /lib/libattr.so.1.1.0
b58c8000 b58e8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58e9000 b58ee000 r-xp /usr/lib/libffi.so.6.0.2
b58ff000 b5917000 r-xp /lib/libz.so.1.2.8
b5927000 b5929000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5939000 b5a0e000 r-xp /usr/lib/libxml2.so.2.9.2
b5a23000 b5abe000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ada000 b5add000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aed000 b5b06000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b17000 b5b28000 r-xp /lib/libresolv-2.20-2014.11.so
b5b3c000 b5bb6000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bcb000 b5bcd000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bdd000 b5be4000 r-xp /usr/lib/libembryo.so.1.13.0
b5bf4000 b5bfe000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c0f000 b5c27000 r-xp /usr/lib/libpng12.so.0.50.0
b5c38000 b5c5b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c7c000 b5c90000 r-xp /usr/lib/libector.so.1.13.0
b5ca1000 b5cb9000 r-xp /usr/lib/liblua-5.1.so
b5cca000 b5d21000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d35000 b5d5d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d6e000 b5d81000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d92000 b5dcc000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5ddd000 b5deb000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dfb000 b5e03000 r-xp /usr/lib/libtbm.so.1.0.0
b5e13000 b5e20000 r-xp /usr/lib/libeio.so.1.13.0
b5e30000 b5e32000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e42000 b5e47000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e57000 b5e6e000 r-xp /usr/lib/libefreet.so.1.13.0
b5e80000 b5ea0000 r-xp /usr/lib/libeldbus.so.1.13.0
b5eb0000 b5ed0000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ed2000 b5ed8000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ee8000 b5ef9000 r-xp /usr/lib/libemotion.so.1.13.0
b5f0a000 b5f11000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f21000 b5f30000 r-xp /usr/lib/libeo.so.1.13.0
b5f41000 b5f53000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f64000 b5f69000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f79000 b5f92000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fa2000 b5fbf000 r-xp /usr/lib/libeet.so.1.13.0
b5fd8000 b6020000 r-xp /usr/lib/libeina.so.1.13.0
b6031000 b6041000 r-xp /usr/lib/libefl.so.1.13.0
b6052000 b6137000 r-xp /usr/lib/libicuuc.so.51.1
b6154000 b6294000 r-xp /usr/lib/libicui18n.so.51.1
b62ab000 b62e3000 r-xp /usr/lib/libecore_x.so.1.13.0
b62f5000 b62f8000 r-xp /lib/libcap.so.2.21
b6308000 b6331000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6342000 b6349000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b635b000 b6392000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63a3000 b648e000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64a1000 b651a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b652c000 b6531000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6541000 b654b000 r-xp /usr/lib/libvconf.so.0.2.45
b655b000 b655d000 r-xp /usr/lib/libvasum.so.0.3.1
b656d000 b656f000 r-xp /usr/lib/libttrace.so.1.1
b657f000 b6582000 r-xp /usr/lib/libiniparser.so.0
b6592000 b65b8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65c8000 b65cd000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65de000 b65f5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6606000 b6671000 r-xp /lib/libm-2.20-2014.11.so
b6682000 b6688000 r-xp /lib/librt-2.20-2014.11.so
b6699000 b66a6000 r-xp /usr/lib/libunwind.so.8.0.1
b66dc000 b6800000 r-xp /lib/libc-2.20-2014.11.so
b6815000 b682e000 r-xp /lib/libgcc_s-4.9.so.1
b683e000 b6920000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6931000 b695b000 r-xp /usr/lib/libdbus-1.so.3.8.12
b696c000 b69a8000 r-xp /usr/lib/libsystemd.so.0.4.0
b69aa000 b6a2d000 r-xp /usr/lib/libedje.so.1.13.0
b6a40000 b6a5e000 r-xp /usr/lib/libecore.so.1.13.0
b6a7e000 b6c05000 r-xp /usr/lib/libevas.so.1.13.0
b6c3a000 b6c4e000 r-xp /lib/libpthread-2.20-2014.11.so
b6c62000 b6e96000 r-xp /usr/lib/libelementary.so.1.13.0
b6ec5000 b6ec9000 r-xp /usr/lib/libsmack.so.1.0.0
b6ed9000 b6ee0000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ef0000 b6ef2000 r-xp /usr/lib/libdlog.so.0.0.0
b6f02000 b6f05000 r-xp /usr/lib/libbundle.so.0.1.22
b6f15000 b6f17000 r-xp /lib/libdl-2.20-2014.11.so
b6f28000 b6f40000 r-xp /usr/lib/libaul.so.0.1.0
b6f54000 b6f59000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f6a000 b6f77000 r-xp /usr/lib/liblptcp.so
b6f89000 b6f8d000 r-xp /usr/lib/libsys-assert.so
b6f9e000 b6fbe000 r-xp /lib/ld-2.20-2014.11.so
b6fcf000 b6fd4000 r-xp /usr/bin/launchpad-loader
b7e6e000 b82c3000 rw-p [heap]
be8d8000 be8f9000 rw-p [stack]
be8d8000 be8f9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3110)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6707b84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
( 3262): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
06-01 15:07:45.664+0900 E/rpm-installer( 3262): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
06-01 15:07:45.664+0900 E/rpm-installer( 3262): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
06-01 15:07:45.724+0900 E/PKGMGR_PARSER( 3262): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-01 15:07:45.724+0900 I/PRIVACY-MANAGER-CLIENT( 3262): SocketClient.cpp: SocketClient(37) > Client created
06-01 15:07:45.724+0900 I/PRIVACY-MANAGER-CLIENT( 3262): SocketClient.cpp: connect(62) > Client connected
06-01 15:07:45.724+0900 I/PRIVACY-MANAGER-SERVER(  916): SocketService.cpp: mainloop(230) > Got incoming connection
06-01 15:07:45.734+0900 I/PRIVACY-MANAGER-CLIENT( 3262): SocketClient.cpp: disconnect(72) > Client disconnected
06-01 15:07:45.734+0900 E/PKGMGR_CERT( 3262): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-01 15:07:45.734+0900 E/PKGMGR_CERT( 3262): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-01 15:07:45.744+0900 E/PKGMGR_CERT( 3262): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-01 15:07:45.774+0900 E/rpm-installer( 3262): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
06-01 15:07:45.784+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.784+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.784+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.784+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
06-01 15:07:45.784+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
06-01 15:07:45.784+0900 E/ESD     (  894): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
06-01 15:07:45.784+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.784+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.784+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.784+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.784+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.784+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.794+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.794+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.794+0900 W/AUL_AMD (  612): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
06-01 15:07:45.794+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.794+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.794+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.794+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
06-01 15:07:45.794+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.794+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
06-01 15:07:45.794+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.794+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.794+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.794+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.804+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:45.874+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-01 15:07:45.874+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-01 15:07:47.536+0900 E/PKGMGR_SERVER( 3259): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3262]
06-01 15:07:47.836+0900 E/PKGMGR_SERVER( 3259): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 15:07:47.836+0900 E/PKGMGR_SERVER( 3259): pkgmgr-server.c: main(2471) > package manager server terminated.
06-01 15:07:48.507+0900 E/PKGMGR  ( 3312): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-01 15:07:48.587+0900 E/PKGMGR_SERVER( 3314): pkgmgr-server.c: main(2414) > package manager server start
06-01 15:07:48.647+0900 E/PKGMGR_SERVER( 3314): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-01 15:07:48.657+0900 E/PKGMGR_INFO( 3314): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-01 15:07:48.657+0900 E/rpm-installer( 3314): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-01 15:07:48.667+0900 E/PKGMGR_SERVER( 3314): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-01 15:07:48.677+0900 E/PKGMGR  ( 3312): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[33120002]
06-01 15:07:48.787+0900 E/PKGMGR_INSTALLER( 3317): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-01 15:07:48.787+0900 E/rpm-installer( 3317): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-01 15:07:48.807+0900 E/rpm-installer( 3317): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-01 15:07:48.807+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-01 15:07:48.807+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-01 15:07:48.807+0900 E/rpm-installer( 3317): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-01 15:07:48.807+0900 E/rpm-installer( 3317): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-01 15:07:48.867+0900 W/CERT_SVC_VCORE( 3317): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
06-01 15:07:48.927+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-01 15:07:48.927+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
06-01 15:07:48.927+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-01 15:07:48.927+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [30]
06-01 15:07:48.927+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.927+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:48.937+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-01 15:07:49.208+0900 E/rpm-installer( 3317): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-01 15:07:49.208+0900 E/PKGMGR_PARSER( 3317): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-01 15:07:49.218+0900 E/PKGMGR_PARSER( 3317): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-01 15:07:49.248+0900 I/PRIVACY-MANAGER-CLIENT( 3317): SocketClient.cpp: SocketClient(37) > Client created
06-01 15:07:49.458+0900 E/PKGMGR_PARSER( 3317): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
06-01 15:07:49.478+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
06-01 15:07:49.488+0900 E/PKGMGR_CERT( 3317): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-01 15:07:49.488+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.488+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-01 15:07:49.488+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [60]
06-01 15:07:49.488+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
06-01 15:07:49.488+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.498+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.508+0900 E/rpm-installer( 3317): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-01 15:07:49.528+0900 E/rpm-installer( 3317): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-01 15:07:49.538+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [100]
06-01 15:07:49.538+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:49.538+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:50.839+0900 E/PKGMGR_SERVER( 3314): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-01 15:07:51.400+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-01 15:07:51.400+0900 I/Tizen::App( 1233): (78) > Installation is Completed. [Package = org.example.client]
06-01 15:07:51.400+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-01 15:07:51.400+0900 I/Tizen::App( 1233): (671) > Enter. package(org.example.client), installationResult(0)
06-01 15:07:51.400+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.400+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 I/Tizen::App( 1233): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.410+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.420+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-01 15:07:51.430+0900 I/Tizen::App( 1233): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-01 15:07:51.440+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-01 15:07:51.450+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-01 15:07:51.450+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-01 15:07:51.450+0900 E/PKGMGR_INFO( 1233): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-01 15:07:51.450+0900 I/Tizen::App( 1233): (683) > Application count(1) in this package
06-01 15:07:51.450+0900 I/Tizen::App( 1233): (840) > Enter.
06-01 15:07:51.450+0900 I/Tizen::App( 1233): (703) > Exit.
06-01 15:07:51.460+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-01 15:07:51.460+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-01 15:07:51.460+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-01 15:07:51.460+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-01 15:07:51.460+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-01 15:07:51.460+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-01 15:07:51.460+0900 I/Tizen::App( 1233): (416) > appName = [client]
06-01 15:07:51.460+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-01 15:07:51.460+0900 I/Tizen::App( 1233): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-01 15:07:51.470+0900 I/Tizen::App( 1233): (131) > Enter
06-01 15:07:51.470+0900 I/Tizen::App( 1233): (137) > org.example.client does not have launch condition
06-01 15:07:51.470+0900 I/Tizen::App( 1233): (883) > Exit.
06-01 15:07:51.470+0900 E/PKGMGR_SERVER( 3314): pkgmgr-server.c: sighandler(417) > child NORMAL exit [3317]
06-01 15:07:51.480+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-01 15:07:51.480+0900 E/HOME_APPS(  867): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-01 15:07:51.480+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-01 15:07:51.480+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-01 15:07:51.500+0900 E/util-view(  867): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-01 15:07:51.510+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-01 15:07:52.841+0900 E/PKGMGR_SERVER( 3314): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 15:07:52.841+0900 E/PKGMGR_SERVER( 3314): pkgmgr-server.c: main(2471) > package manager server terminated.
06-01 15:07:55.594+0900 W/AUL     ( 3373): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-01 15:07:55.594+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
06-01 15:07:55.604+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-01 15:07:55.614+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-01 15:07:55.614+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-01 15:07:55.614+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 3373
06-01 15:07:55.614+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-01 15:07:55.624+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
06-01 15:07:55.624+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 15:07:55.624+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
06-01 15:07:55.634+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-01 15:07:55.634+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
06-01 15:07:55.644+0900 I/abc     ( 3110): abc
06-01 15:07:55.644+0900 I/CAPI_APPFW_APPLICATION( 3110): app_main.c: ui_app_main(789) > app_efl_main
06-01 15:07:55.644+0900 I/CAPI_APPFW_APPLICATION( 3110): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-01 15:07:55.684+0900 E/TBM     ( 3110): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-01 15:07:55.734+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 3110, appid: org.example.client
06-01 15:07:55.734+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-01 15:07:55.734+0900 W/AUL     ( 3373): launch.c: app_request_to_launchpad(425) > request cmd(0) result(3110)
06-01 15:07:55.944+0900 I/APP_CORE( 3110): appcore-efl.c: __do_app(514) > [APP 3110] Event: RESET State: CREATED
06-01 15:07:55.944+0900 I/CAPI_APPFW_APPLICATION( 3110): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-01 15:07:55.954+0900 E/EFL     ( 3110): edje<3110> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-01 15:07:55.954+0900 E/EFL     ( 3110): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:07:55.964+0900 E/EFL     ( 3110): edje<3110> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-01 15:07:55.964+0900 E/EFL     ( 3110): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:07:55.964+0900 E/EFL     ( 3110): edje<3110> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-01 15:07:55.964+0900 E/EFL     ( 3110): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:07:55.974+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-01 15:07:55.974+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-01 15:07:55.974+0900 W/APP_CORE( 3110): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
06-01 15:07:55.974+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
06-01 15:07:55.994+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
06-01 15:07:55.994+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-01 15:07:55.994+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-01 15:07:56.004+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-01 15:07:56.084+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
06-01 15:07:56.084+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-01 15:07:56.084+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
06-01 15:07:56.084+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
06-01 15:07:56.084+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
06-01 15:07:56.084+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
06-01 15:07:56.094+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(3110) status(3)
06-01 15:07:56.094+0900 I/APP_CORE( 3110): appcore-efl.c: __do_app(514) > [APP 3110] Event: RESUME State: CREATED
06-01 15:07:56.094+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 15:07:56.094+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-01 15:07:56.094+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(3110)
06-01 15:07:56.094+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 3110, appid: org.example.client, status: fg
06-01 15:07:56.104+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-01 15:07:56.104+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-01 15:07:56.104+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
06-01 15:07:56.114+0900 I/APP_CORE( 3110): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-01 15:07:56.114+0900 I/APP_CORE( 3110): appcore-efl.c: __do_app(625) > [APP 3110] Initial Launching, call the resume_cb
06-01 15:07:56.114+0900 I/CAPI_APPFW_APPLICATION( 3110): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-01 15:07:56.455+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(3110) status(0)
06-01 15:07:56.795+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
06-01 15:07:56.795+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1896
06-01 15:07:56.805+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 3110.
06-01 15:07:57.556+0900 I/UXT     ( 3386): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-01 15:07:58.307+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845875469
06-01 15:07:58.307+0900 I/MY_LOG  ( 3110): Button pressed
06-01 15:07:58.417+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845875579
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf.c: vconf_get_bool(2729) > vconf_get_bool(3110) : db/ise/keysound error
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
06-01 15:07:58.417+0900 E/VCONF   ( 3110): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
06-01 15:07:58.477+0900 I/MY_LOG  ( 3110): Button unpressed
06-01 15:07:59.057+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845876218
06-01 15:07:59.057+0900 I/MY_LOG  ( 3110): Button pressed
06-01 15:07:59.137+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845876305
06-01 15:07:59.147+0900 I/MY_LOG  ( 3110): Button unpressed
06-01 15:07:59.177+0900 D/basicui ( 3110): successed to load edc file
06-01 15:07:59.197+0900 E/EFL     ( 3110): elementary<3110> elm_layout.c:991 _elm_layout_elm_container_content_set() could not swallow 0x800787c5 into part 'swallow_content'
06-01 15:08:00.098+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
06-01 15:08:00.108+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 3:08
06-01 15:08:00.108+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 3:08"
06-01 15:08:00.108+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 3:08"
06-01 15:08:00.108+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
06-01 15:08:00.108+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145540527 Time: <font_size=31> </font_size> <font_size=31> 오후 3:08</font_size></font>"
06-01 15:08:01.099+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
06-01 15:08:01.530+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845878697
06-01 15:08:01.620+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845878785
06-01 15:08:01.680+0900 E/EFL     ( 3110): edje<3110> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p9';
06-01 15:08:01.680+0900 E/EFL     ( 3110): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 15:08:02.621+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=845879784
06-01 15:08:02.711+0900 E/EFL     ( 3110): ecore_x<3110> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=845879871
06-01 15:08:02.851+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-01 15:08:02.861+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
06-01 15:08:02.861+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 3110 pgid = 3110
06-01 15:08:02.861+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 15:08:02.861+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-01 15:08:02.861+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(3110)
06-01 15:08:02.861+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
06-01 15:08:02.861+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
06-01 15:08:02.931+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-01 15:08:02.931+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-01 15:08:02.931+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
06-01 15:08:02.931+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[3110] terminate event is forwarded
06-01 15:08:02.931+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
06-01 15:08:02.931+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 3110, ]
06-01 15:08:02.931+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
06-01 15:08:02.931+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
06-01 15:08:02.931+0900 I/Tizen::App( 1233): (512) > Not registered pid(3110)
06-01 15:08:02.931+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
06-01 15:08:02.931+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-01 15:08:02.931+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 3110
06-01 15:08:02.931+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-01 15:08:02.941+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
06-01 15:08:02.941+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-01 15:08:02.941+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
06-01 15:08:02.941+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 3110
06-01 15:08:02.941+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 3110
06-01 15:08:02.941+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1900
06-01 15:08:02.951+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
06-01 15:08:02.961+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-01 15:08:02.961+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 3110.
06-01 15:08:02.971+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-01 15:08:02.991+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
06-01 15:08:02.991+0900 I/Tizen::Io( 1233): (729) > Entry not found
06-01 15:08:03.011+0900 I/Tizen::System( 1233): (157) > change brightness system value.
06-01 15:08:03.031+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
06-01 15:08:03.041+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-01 15:08:03.041+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-01 15:08:03.041+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
06-01 15:08:03.041+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-01 15:08:03.051+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
06-01 15:08:03.061+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
06-01 15:08:03.081+0900 W/CRASH_MANAGER( 3391): worker.c: worker_job(1199) > 0603110636c69149629728
