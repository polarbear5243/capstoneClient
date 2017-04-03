S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 2797
Date: 2017-04-02 00:05:06+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0xb283dfd8

Register Information
r0   = 0x00000004, r1   = 0x00000000
r2   = 0x00000000, r3   = 0xb41064c0
r4   = 0xb400da3c, r5   = 0xbe886484
r6   = 0x00000001, r7   = 0xbe885f08
r8   = 0xbe886478, r9   = 0xb7414ab0
r10  = 0xbe886498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbe885ee8
lr   = 0xb283dfd7, pc   = 0xb283dfd8
cpsr = 0x60030030

Memory Information
MemTotal:   987012 KB
MemFree:    187092 KB
Buffers:     40872 KB
Cached:     319184 KB
VmPeak:      98432 KB
VmSize:      98428 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19424 KB
VmRSS:       19424 KB
VmData:      30112 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35644 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2797 TID = 2797
2797 2802 5892 5893 

Maps Information
b13ef000 b13f7000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1409000 b1c08000 rw-p [stack:5893]
b1c08000 b1c09000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c19000 b1c2d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c41000 b1c42000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c52000 b1c55000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c66000 b1c67000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c77000 b1c79000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c89000 b1c8b000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c9b000 b1cab000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cbb000 b1cc7000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cd9000 b24d8000 rw-p [stack:5892]
b2809000 b2810000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2823000 b2829000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2839000 b2849000 r-xp /opt/usr/apps/org.example.client/bin/client
b2992000 b2a75000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2aac000 b2ad4000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ae6000 b32e5000 rw-p [stack:2802]
b32e5000 b32e7000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32f7000 b3301000 r-xp /lib/libnss_files-2.20-2014.11.so
b3312000 b331b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b332c000 b333d000 r-xp /lib/libnsl-2.20-2014.11.so
b3350000 b3356000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3367000 b3368000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3390000 b3397000 r-xp /usr/lib/libminizip.so.1.0.0
b33a7000 b33ac000 r-xp /usr/lib/libstorage.so.0.1
b33bc000 b341b000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3431000 b3445000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3455000 b3499000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34a9000 b34b1000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34c1000 b34f1000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3504000 b35bd000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35d1000 b3624000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3635000 b3650000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3660000 b3721000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3734000 b3744000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3754000 b3761000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3772000 b3779000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3789000 b37ca000 r-xp /usr/lib/libmdm.so.1.2.12
b37da000 b37e2000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37f1000 b3801000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3822000 b3882000 r-xp /usr/lib/libasound.so.2.0.0
b3894000 b3897000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38a7000 b38aa000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38ba000 b38bf000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38cf000 b38d0000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38e0000 b38eb000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38ff000 b3906000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3916000 b391c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b392c000 b3931000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3941000 b395c000 r-xp /usr/lib/libmmfsound.so.0.1.0
b396c000 b3973000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3983000 b3986000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3997000 b39c5000 r-xp /usr/lib/libidn.so.11.5.44
b39d5000 b39eb000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39fc000 b3a06000 r-xp /usr/lib/libcares.so.2.1.0
b3a16000 b3a20000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a30000 b3a32000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a42000 b3a43000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a53000 b3a57000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a68000 b3a90000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aa1000 b3aca000 r-xp /usr/lib/libturbojpeg.so
b3aea000 b3af0000 r-xp /usr/lib/libgif.so.4.1.6
b3b00000 b3b46000 r-xp /usr/lib/libcurl.so.4.3.0
b3b57000 b3b78000 r-xp /usr/lib/libexif.so.12.3.3
b3b93000 b3ba8000 r-xp /usr/lib/libtts.so
b3bb9000 b3bc1000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bd1000 b3c97000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cb7000 b3daf000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dce000 b3e9c000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eb3000 b3eb5000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ec5000 b3ecb000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3edb000 b3efe000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f0f000 b3f11000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f21000 b3f23000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f34000 b3f39000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f50000 b3f52000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f62000 b3f69000 r-xp /usr/lib/libsensord-share.so
b3f79000 b3f91000 r-xp /usr/lib/libsensor.so.1.1.0
b3fa2000 b3fa5000 r-xp /usr/lib/libXv.so.1.0.0
b3fb5000 b3fba000 r-xp /usr/lib/libutilX.so.1.1.0
b3fca000 b3fcf000 r-xp /usr/lib/libappcore-common.so.1.1
b3fdf000 b3fe6000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3ff9000 b3ffd000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b400e000 b40ec000 r-xp /usr/lib/libCOREGL.so.4.0
b410c000 b410f000 r-xp /usr/lib/libuuid.so.1.3.0
b411f000 b4136000 r-xp /usr/lib/libblkid.so.1.1.0
b4147000 b4149000 r-xp /usr/lib/libXau.so.6.0.0
b4159000 b41a0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41b2000 b41b8000 r-xp /usr/lib/libjson-c.so.2.0.1
b41c9000 b41cd000 r-xp /usr/lib/libogg.so.0.7.1
b41dd000 b41ff000 r-xp /usr/lib/libvorbis.so.0.4.3
b420f000 b42f3000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b430f000 b4312000 r-xp /usr/lib/libEGL.so.1.4
b4323000 b4329000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4339000 b433b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b434b000 b4358000 r-xp /usr/lib/libGLESv2.so.2.0
b4369000 b43cb000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43e0000 b43f8000 r-xp /usr/lib/libmount.so.1.1.0
b440a000 b441e000 r-xp /usr/lib/libxcb.so.1.1.0
b442e000 b4435000 r-xp /lib/libcrypt-2.20-2014.11.so
b446d000 b446f000 r-xp /usr/lib/libiri.so
b447f000 b448a000 r-xp /usr/lib/libgpg-error.so.0.15.0
b449b000 b44d1000 r-xp /usr/lib/libpulse.so.0.16.2
b44e2000 b4525000 r-xp /usr/lib/libsndfile.so.1.0.25
b453a000 b454f000 r-xp /lib/libexpat.so.1.5.2
b4561000 b461f000 r-xp /usr/lib/libcairo.so.2.11200.14
b4633000 b463b000 r-xp /usr/lib/libdrm.so.2.4.0
b464b000 b464e000 r-xp /usr/lib/libdri2.so.0.0.0
b465e000 b46ac000 r-xp /usr/lib/libssl.so.1.0.0
b46c1000 b46cd000 r-xp /usr/lib/libeeze.so.1.13.0
b46de000 b46e7000 r-xp /usr/lib/libethumb.so.1.13.0
b46f7000 b46fa000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b470a000 b48c1000 r-xp /usr/lib/libcrypto.so.1.0.0
b56ac000 b56b5000 r-xp /usr/lib/libXi.so.6.1.0
b56c5000 b56c7000 r-xp /usr/lib/libXgesture.so.7.0.0
b56d7000 b56db000 r-xp /usr/lib/libXtst.so.6.1.0
b56eb000 b56f1000 r-xp /usr/lib/libXrender.so.1.3.0
b5701000 b5707000 r-xp /usr/lib/libXrandr.so.2.2.0
b5717000 b5719000 r-xp /usr/lib/libXinerama.so.1.0.0
b572a000 b572d000 r-xp /usr/lib/libXfixes.so.3.1.0
b573d000 b5748000 r-xp /usr/lib/libXext.so.6.4.0
b5758000 b575a000 r-xp /usr/lib/libXdamage.so.1.1.0
b576a000 b576c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b577c000 b585e000 r-xp /usr/lib/libX11.so.6.3.0
b5872000 b5879000 r-xp /usr/lib/libXcursor.so.1.0.2
b5889000 b58a1000 r-xp /usr/lib/libudev.so.1.6.0
b58a3000 b58a6000 r-xp /lib/libattr.so.1.1.0
b58b6000 b58d6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58d7000 b58dc000 r-xp /usr/lib/libffi.so.6.0.2
b58ed000 b5905000 r-xp /lib/libz.so.1.2.8
b5915000 b5917000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5927000 b59fc000 r-xp /usr/lib/libxml2.so.2.9.2
b5a11000 b5aac000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ac8000 b5acb000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5adb000 b5af4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b05000 b5b16000 r-xp /lib/libresolv-2.20-2014.11.so
b5b2a000 b5ba4000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bb9000 b5bbb000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bcb000 b5bd2000 r-xp /usr/lib/libembryo.so.1.13.0
b5be2000 b5bec000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bfd000 b5c15000 r-xp /usr/lib/libpng12.so.0.50.0
b5c26000 b5c49000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c6a000 b5c7e000 r-xp /usr/lib/libector.so.1.13.0
b5c8f000 b5ca7000 r-xp /usr/lib/liblua-5.1.so
b5cb8000 b5d0f000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d23000 b5d4b000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d5c000 b5d6f000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d80000 b5dba000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dcb000 b5dd9000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5de9000 b5df1000 r-xp /usr/lib/libtbm.so.1.0.0
b5e01000 b5e0e000 r-xp /usr/lib/libeio.so.1.13.0
b5e1e000 b5e20000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e30000 b5e35000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e45000 b5e5c000 r-xp /usr/lib/libefreet.so.1.13.0
b5e6e000 b5e8e000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e9e000 b5ebe000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ec0000 b5ec6000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ed6000 b5ee7000 r-xp /usr/lib/libemotion.so.1.13.0
b5ef8000 b5eff000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f0f000 b5f1e000 r-xp /usr/lib/libeo.so.1.13.0
b5f2f000 b5f41000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f52000 b5f57000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f67000 b5f80000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f90000 b5fad000 r-xp /usr/lib/libeet.so.1.13.0
b5fc6000 b600e000 r-xp /usr/lib/libeina.so.1.13.0
b601f000 b602f000 r-xp /usr/lib/libefl.so.1.13.0
b6040000 b6125000 r-xp /usr/lib/libicuuc.so.51.1
b6142000 b6282000 r-xp /usr/lib/libicui18n.so.51.1
b6299000 b62d1000 r-xp /usr/lib/libecore_x.so.1.13.0
b62e3000 b62e6000 r-xp /lib/libcap.so.2.21
b62f6000 b631f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6330000 b6337000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6349000 b6380000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6391000 b647c000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b648f000 b6508000 r-xp /usr/lib/libsqlite3.so.0.8.6
b651a000 b651f000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b652f000 b6539000 r-xp /usr/lib/libvconf.so.0.2.45
b6549000 b654b000 r-xp /usr/lib/libvasum.so.0.3.1
b655b000 b655d000 r-xp /usr/lib/libttrace.so.1.1
b656d000 b6570000 r-xp /usr/lib/libiniparser.so.0
b6580000 b65a6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65b6000 b65bb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65cc000 b65e3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65f4000 b665f000 r-xp /lib/libm-2.20-2014.11.so
b6670000 b6676000 r-xp /lib/librt-2.20-2014.11.so
b6687000 b6694000 r-xp /usr/lib/libunwind.so.8.0.1
b66ca000 b67ee000 r-xp /lib/libc-2.20-2014.11.so
b6803000 b681c000 r-xp /lib/libgcc_s-4.9.so.1
b682c000 b690e000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b691f000 b6949000 r-xp /usr/lib/libdbus-1.so.3.8.12
b695a000 b6996000 r-xp /usr/lib/libsystemd.so.0.4.0
b6998000 b6a1b000 r-xp /usr/lib/libedje.so.1.13.0
b6a2e000 b6a4c000 r-xp /usr/lib/libecore.so.1.13.0
b6a6c000 b6bf3000 r-xp /usr/lib/libevas.so.1.13.0
b6c28000 b6c3c000 r-xp /lib/libpthread-2.20-2014.11.so
b6c50000 b6e84000 r-xp /usr/lib/libelementary.so.1.13.0
b6eb3000 b6eb7000 r-xp /usr/lib/libsmack.so.1.0.0
b6ec7000 b6ece000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ede000 b6ee0000 r-xp /usr/lib/libdlog.so.0.0.0
b6ef0000 b6ef3000 r-xp /usr/lib/libbundle.so.0.1.22
b6f03000 b6f05000 r-xp /lib/libdl-2.20-2014.11.so
b6f16000 b6f2e000 r-xp /usr/lib/libaul.so.0.1.0
b6f42000 b6f47000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f58000 b6f65000 r-xp /usr/lib/liblptcp.so
b6f77000 b6f7b000 r-xp /usr/lib/libsys-assert.so
b6f8c000 b6fac000 r-xp /lib/ld-2.20-2014.11.so
b6fbd000 b6fc2000 r-xp /usr/bin/launchpad-loader
b73ae000 b75d9000 rw-p [heap]
be866000 be887000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2797)
Call Stack Count: 14
 0:  + 0x0 (0xb283dfd8) [/opt/usr/apps/org.example.client/bin/client] + 0x4fd8
 1: _ZN7MyLogin6drawUIEP9Naviframe + 0xd0 (0xb283cc8d) [/opt/usr/apps/org.example.client/bin/client] + 0x3c8d
 2: _ZN7MyLoginC2EP9Naviframe + 0x48 (0xb283cb91) [/opt/usr/apps/org.example.client/bin/client] + 0x3b91
 3: _ZN8MyWindow8onCreateEv + 0x110 (0xb283c9c5) [/opt/usr/apps/org.example.client/bin/client] + 0x39c5
 4: _ZN6Window10app_createEPv + 0x8e (0xb2842763) [/opt/usr/apps/org.example.client/bin/client] + 0x9763
 5: _ZN6Window17static_app_createEPv + 0x24 (0xb28428dd) [/opt/usr/apps/org.example.client/bin/client] + 0x98dd
 6: (0xb3ffb4f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 7: appcore_efl_main + 0x152 (0xb6f45203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 8: ui_app_main + 0xc0 (0xb3ffb909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 9: _ZN6Window10makeWindowEiPPc + 0x11e (0xb2842c67) [/opt/usr/apps/org.example.client/bin/client] + 0x9c67
10: main + 0x40 (0xb283c74d) [/opt/usr/apps/org.example.client/bin/client] + 0x374d
11: (0xb6fbebb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
12: __libc_start_main + 0x114 (0xb66e04bc) [/lib/libc.so.6] + 0x164bc
13: (0xb6fbeeb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
m( 1188): (273) > Current App[com.samsun] is already actived.
04-02 00:03:46.242+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 12
04-02 00:03:46.242+0900 E/EFL     (  348): evas-gl_x11<348> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-02 00:03:46.252+0900 E/RUA     ( 2860): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 17, ncols : 5
04-02 00:03:46.252+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
04-02 00:03:46.252+0900 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5486
04-02 00:03:46.252+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 12
04-02 00:03:46.252+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
04-02 00:03:46.252+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
04-02 00:03:46.252+0900 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 2843
04-02 00:03:46.252+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 12
04-02 00:03:46.262+0900 E/EFL     (  348): evas-gl_x11<348> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.samsung-log-relay-mobile-service) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
04-02 00:03:46.262+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
04-02 00:03:46.272+0900 E/EFL     (  348): evas-gl_x11<348> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-02 00:03:46.292+0900 E/EFL     (  348): evas-gl_x11<348> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-02 00:03:46.312+0900 E/EFL     (  348): evas-gl_x11<348> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-02 00:03:46.322+0900 E/EFL     (  348): evas-gl_x11<348> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-02 00:03:46.332+0900 I/APP_CORE( 2860): appcore-efl.c: __do_app(514) > [APP 2860] Event: RESET State: CREATED
04-02 00:03:46.332+0900 I/CAPI_APPFW_APPLICATION( 2860): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-02 00:03:46.332+0900 E/EFL     ( 2860): edje<2860> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-02 00:03:46.332+0900 E/EFL     ( 2860): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 00:03:46.332+0900 E/EFL     ( 2860): edje<2860> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-02 00:03:46.332+0900 E/EFL     ( 2860): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 00:03:46.342+0900 W/APP_CORE( 2860): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00003
04-02 00:03:46.342+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 35
04-02 00:03:46.342+0900 E/EFL     (  850): ecore_x<850> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=1999552
04-02 00:03:46.342+0900 W/STARTER (  720): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
04-02 00:03:46.342+0900 E/cluster-view(  850): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
04-02 00:03:46.342+0900 E/EFL     (  836): ecore_x<836> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=1999552
04-02 00:03:46.342+0900 E/EFL     (  348): evas-gl_x11<348> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-02 00:03:46.342+0900 E/STARTER (  720): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-02 00:03:46.352+0900 E/STARTER (  720): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-02 00:03:46.352+0900 E/STARTER (  720): )
04-02 00:03:46.352+0900 I/SYSPOPUP(  847): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-02 00:03:46.352+0900 I/SYSPOPUP(  847): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-02 00:03:46.352+0900 E/VOLUME  (  847): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-02 00:03:46.352+0900 E/VOLUME  (  847): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-02 00:03:46.522+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(2860) status(0)
04-02 00:03:46.522+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(2860) status(0)
04-02 00:03:46.522+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: PAUSE State: RUNNING
04-02 00:03:46.522+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-02 00:03:46.522+0900 E/cluster-home(  850): homescreen.cpp: OnPause(260) >  app pause
04-02 00:03:46.522+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(850) status(4)
04-02 00:03:46.522+0900 W/AUL     (  608): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(850)
04-02 00:03:46.522+0900 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 850, appid: com.samsung.homescreen, status: bg
04-02 00:03:46.532+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(2860) status(3)
04-02 00:03:46.532+0900 W/AUL_AMD (  608): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-02 00:03:46.532+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-02 00:03:46.532+0900 W/AUL     (  608): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(2860)
04-02 00:03:46.532+0900 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2860, appid: com.samsung.task-mgr, status: fg
04-02 00:03:46.532+0900 E/EFL     (  348): evas-gl_x11<348> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-02 00:03:46.542+0900 I/CAPI_WIDGET_APPLICATION( 1217): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-02 00:03:46.542+0900 I/CAPI_WIDGET_APPLICATION( 1217): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-02 00:03:46.542+0900 W/AUL     ( 1217): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1217, appid: com.samsung.weather-m-widget, status: bg
04-02 00:03:46.552+0900 I/APP_CORE( 2860): appcore-efl.c: __do_app(514) > [APP 2860] Event: RESUME State: CREATED
04-02 00:03:46.562+0900 I/APP_CORE( 2860): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-02 00:03:46.562+0900 I/APP_CORE( 2860): appcore-efl.c: __do_app(625) > [APP 2860] Initial Launching, call the resume_cb
04-02 00:03:46.562+0900 I/CAPI_APPFW_APPLICATION( 2860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-02 00:03:46.892+0900 E/EFL     ( 2860): ecore_x<2860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=2000097
04-02 00:03:47.052+0900 E/EFL     ( 2860): ecore_x<2860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=2000264
04-02 00:03:47.052+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
04-02 00:03:47.052+0900 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 2843
04-02 00:03:47.052+0900 W/AUL     ( 2860): launch.c: app_request_to_launchpad(396) > request cmd(4) to(2843)
04-02 00:03:47.052+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 4
04-02 00:03:47.062+0900 W/AUL_AMD (  608): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(2843), cmd(4)
04-02 00:03:47.062+0900 W/AUL     ( 2860): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
04-02 00:03:47.062+0900 I/APP_CORE( 2843): appcore-efl.c: __do_app(514) > [APP 2843] Event: TERMINATE State: PAUSED
04-02 00:03:47.062+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
04-02 00:03:47.062+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
04-02 00:03:47.062+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
04-02 00:03:47.062+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
04-02 00:03:47.103+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 2843): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 37
04-02 00:03:47.103+0900 E/APP_CORE( 2843): appcore-efl.c: _capture_and_make_file(1619) > win[6000003] widget[720] height[1280]
04-02 00:03:47.113+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 33
04-02 00:03:47.113+0900 E/APP_CORE( 2843): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [com.samsung.myfile-lite]
04-02 00:03:47.133+0900 I/CAPI_APPFW_APPLICATION( 2843): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-02 00:03:47.133+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 2843): media_content.c: media_content_disconnect(940) > [32m[2843]ref count changed to: 0
04-02 00:03:47.143+0900 E/RESOURCED(  676): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.442
04-02 00:03:47.143+0900 I/Tizen::App( 1188): (499) > LaunchedApp(com.samsung.task-mgr)
04-02 00:03:47.143+0900 I/Tizen::App( 1188): (733) > Finished invoking application event listener for com.samsung.task-mgr, 2860.
04-02 00:03:47.153+0900 E/CLOUD_CONTENT_SYNC_CLIENT( 2843): cs_client.c: cloud_content_sync_folder_unset_changed_cb(3749) > [0;31m* Critical * Invalid handle[0;m
04-02 00:03:47.153+0900 E/CLOUD_CONTENT_SYNC_CLIENT( 2843): cs_client.c: cloud_content_sync_content_unset_changed_cb(3662) > [0;31m* Critical * Invalid handle[0;m
04-02 00:03:47.153+0900 W/MYFILES ( 2843): mf-cloud-service.c: mf_cloud_content_destroy_handle(61) > handle is NULL
04-02 00:03:47.153+0900 E/MYFILES ( 2843): mf-cloud-operation.c: mf_cloud_operation_src_list_free(147) > [31mmore is [0][0m
04-02 00:03:47.153+0900 E/EFL     ( 2843): <2843> e_dbus.c:640 e_dbus_shutdown() Init count not greater than 0 in shutdown.
04-02 00:03:47.283+0900 I/MALI    ( 2843): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=2843   close drm_fd=30 
04-02 00:03:47.513+0900 E/EFL     ( 2860): ecore_x<2860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=2000724
04-02 00:03:47.513+0900 I/AUL_PAD ( 1487): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2843 pgid = 2843
04-02 00:03:47.523+0900 I/AUL_PAD ( 1487): sigchild.h: __sigchild_action(143) > dead_pid(2843)
04-02 00:03:47.543+0900 I/AUL_PAD ( 1487): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-02 00:03:47.543+0900 I/AUL_PAD ( 1487): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-02 00:03:47.543+0900 E/AUL_PAD ( 1487): launchpad.c: main(698) > error reading sigchld info
04-02 00:03:47.543+0900 I/Tizen::App( 1188): (243) > App[com.samsung.myfile-lite] pid[2843] terminate event is forwarded
04-02 00:03:47.543+0900 I/Tizen::System( 1188): (256) > osp.accessorymanager.service provider is found.
04-02 00:03:47.543+0900 I/Tizen::System( 1188): (196) > Accessory Owner is removed [com.samsung.myfile-lite, 2843, ]
04-02 00:03:47.543+0900 I/Tizen::System( 1188): (256) > osp.system.service provider is found.
04-02 00:03:47.543+0900 I/Tizen::App( 1188): (506) > TerminatedApp(com.samsung.myfile-lite)
04-02 00:03:47.543+0900 I/Tizen::App( 1188): (512) > Not registered pid(2843)
04-02 00:03:47.543+0900 I/Tizen::System( 1188): (246) > Terminated app [com.samsung.myfile-lite]
04-02 00:03:47.553+0900 I/Tizen::Io( 1188): (729) > Entry not found
04-02 00:03:47.553+0900 I/ESD     (  899): esd_main.c: __esd_app_dead_handler(1773) > pid: 2843
04-02 00:03:47.553+0900 W/AUL_AMD (  608): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2843
04-02 00:03:47.553+0900 E/RESOURCED(  676): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.443
04-02 00:03:47.563+0900 I/Tizen::System( 1188): (157) > change brightness system value.
04-02 00:03:47.563+0900 I/Tizen::App( 1188): (782) > Finished invoking application event listener for com.samsung.myfile-lite, 2843.
04-02 00:03:47.623+0900 E/EFL     ( 2860): ecore_x<2860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=2000835
04-02 00:03:47.623+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
04-02 00:03:47.623+0900 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 5486
04-02 00:03:47.623+0900 W/AUL     ( 2860): launch.c: app_request_to_launchpad(396) > request cmd(4) to(5486)
04-02 00:03:47.623+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 4
04-02 00:03:47.963+0900 I/UXT     ( 5518): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-02 00:03:48.003+0900 E/TBM     ( 5518): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-02 00:03:48.003+0900 I/MALI    ( 5518): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=5518   open drm_fd=30 
04-02 00:03:48.114+0900 E/EFL     ( 5518): edje<5518> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-02 00:03:48.114+0900 E/EFL     ( 5518): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 00:03:48.114+0900 E/EFL     ( 5518): edje<5518> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-02 00:03:48.114+0900 E/EFL     ( 5518): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 00:03:48.114+0900 E/EFL     ( 5518): edje<5518> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-02 00:03:48.114+0900 E/EFL     ( 5518): By the power of Grayskull, your previous Embryo stack is now broken!
04-02 00:03:51.537+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
04-02 00:03:52.067+0900 W/AUL_AMD (  608): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-02 00:03:52.067+0900 W/AUL_AMD (  608): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-02 00:03:52.628+0900 E/AUL_AMD (  608): amd_launch.c: __recv_timeout_handler(1102) > application is not responding : pid(5486) cmd(4)
04-02 00:03:52.628+0900 W/AUL     ( 2860): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
04-02 00:03:52.658+0900 E/EFL     ( 2860): ecore_x<2860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=2003803
04-02 00:03:52.658+0900 E/EFL     ( 2860): ecore_x<2860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=2003903
04-02 00:03:52.678+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 22
04-02 00:03:52.678+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(1201) > app status : 5
04-02 00:03:52.678+0900 W/AUL     (  608): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(2860)
04-02 00:03:52.678+0900 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 2860, appid: com.samsung.task-mgr, status: bg
04-02 00:03:52.688+0900 I/CAPI_APPFW_APPLICATION( 2860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-02 00:03:52.688+0900 W/TASK_MGR_LITE( 2860): task-mgr-lite.c: _pause_app(411) > Close all animation is working, so skip to call elm_exit()
04-02 00:03:52.688+0900 I/CAPI_APPFW_APPLICATION( 2860): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-02 00:03:52.688+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
04-02 00:03:52.698+0900 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-02 00:03:52.698+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: recent_apps_kill_selected(194) > Not running app[com.samsung.myfile-lite]
04-02 00:03:52.698+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
04-02 00:03:52.698+0900 E/AUL_AMD (  608): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 5486
04-02 00:03:52.708+0900 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-02 00:03:52.708+0900 E/TASK_MGR_LITE( 2860): recent_apps.c: recent_apps_kill_selected(194) > Not running app[org.example.client]
04-02 00:03:52.708+0900 E/TASK_MGR_LITE( 2860): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
04-02 00:03:52.708+0900 E/EFL     ( 2860): eo<2860> lib/eo/eo_ptr_indirection.x:295 _eo_obj_pointer_get() eo_id 0x80048243's acvie is  NULL, entry: 0xb32f4228, 0xb8940b18, 0
04-02 00:03:52.708+0900 E/EFL     ( 2860): eo<2860> lib/eo/eo_ptr_indirection.x:301 _eo_obj_pointer_get() obj_id 0x80048243 is not pointing to a valid object. Maybe it has already been freed.
04-02 00:03:52.708+0900 E/EFL     ( 2860): eo<2860> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x80048243) is an invalid ref.
04-02 00:03:52.728+0900 E/APP_CORE( 2860): appcore.c: appcore_flush_memory(793) > Appcore not initialized
04-02 00:03:52.728+0900 E/EFL     (  348): eo<348> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-02 00:03:52.738+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(850) status(3)
04-02 00:03:52.738+0900 W/AUL_AMD (  608): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-02 00:03:52.738+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-02 00:03:52.738+0900 W/AUL     (  608): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(850)
04-02 00:03:52.738+0900 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 850, appid: com.samsung.homescreen, status: fg
04-02 00:03:52.768+0900 W/AUL_AMD (  608): amd_launch.c: __e17_status_handler(3328) > pid(850) status(0)
04-02 00:03:52.788+0900 I/MALI    ( 2860): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=2860   close drm_fd=30 
04-02 00:03:52.808+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: RESUME State: PAUSED
04-02 00:03:52.808+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-02 00:03:52.808+0900 E/cluster-home(  850): homescreen.cpp: OnResume(233) >  app resume
04-02 00:03:52.808+0900 E/EFL     (  348): eo<348> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-02 00:03:52.838+0900 E/weather-widget( 1217): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-02 00:03:52.848+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 15
04-02 00:03:52.868+0900 E/weather-widget( 1217): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-02 00:03:52.868+0900 I/Tizen::System( 1188): (259) > Active app [com.samsun], current [com.samsun] 
04-02 00:03:52.868+0900 I/Tizen::System( 1188): (273) > Current App[com.samsun] is already actived.
04-02 00:03:52.878+0900 E/weather-common( 1217): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-02 00:03:52.918+0900 I/CAPI_NETWORK_CONNECTION( 1217): connection.c: connection_create(409) > New handle created[0xb7d07548]
04-02 00:03:52.928+0900 I/CAPI_NETWORK_CONNECTION( 1217): connection.c: connection_get_type(463) > Connected Network = 2
04-02 00:03:52.928+0900 I/CAPI_NETWORK_CONNECTION( 1217): connection.c: connection_destroy(427) > Destroy handle: 0xb7d07548
04-02 00:03:52.928+0900 E/weather-common( 1217): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-02 00:03:52.938+0900 E/weather-widget( 1217): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-02 00:03:52.938+0900 I/CAPI_WIDGET_APPLICATION( 1217): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-02 00:03:52.938+0900 I/CAPI_WIDGET_APPLICATION( 1217): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-02 00:03:52.938+0900 W/AUL     ( 1217): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1217, appid: com.samsung.weather-m-widget, status: fg
04-02 00:03:53.078+0900 I/AUL_PAD ( 1487): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 2860 pgid = 2860
04-02 00:03:53.078+0900 I/AUL_PAD ( 1487): sigchild.h: __sigchild_action(143) > dead_pid(2860)
04-02 00:03:53.108+0900 I/AUL_PAD ( 1487): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-02 00:03:53.108+0900 I/AUL_PAD ( 1487): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-02 00:03:53.108+0900 E/AUL_PAD ( 1487): launchpad.c: main(698) > error reading sigchld info
04-02 00:03:53.118+0900 I/ESD     (  899): esd_main.c: __esd_app_dead_handler(1773) > pid: 2860
04-02 00:03:53.118+0900 I/Tizen::App( 1188): (243) > App[com.samsung.task-mgr] pid[2860] terminate event is forwarded
04-02 00:03:53.118+0900 I/Tizen::System( 1188): (256) > osp.accessorymanager.service provider is found.
04-02 00:03:53.118+0900 I/Tizen::System( 1188): (196) > Accessory Owner is removed [com.samsung.task-mgr, 2860, ]
04-02 00:03:53.118+0900 I/Tizen::System( 1188): (256) > osp.system.service provider is found.
04-02 00:03:53.118+0900 I/Tizen::App( 1188): (506) > TerminatedApp(com.samsung.task-mgr)
04-02 00:03:53.118+0900 I/Tizen::App( 1188): (512) > Not registered pid(2860)
04-02 00:03:53.118+0900 I/Tizen::System( 1188): (246) > Terminated app [com.samsung.task-mgr]
04-02 00:03:53.118+0900 I/Tizen::Io( 1188): (729) > Entry not found
04-02 00:03:53.118+0900 W/AUL_AMD (  608): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 2860
04-02 00:03:53.118+0900 W/AUL_AMD (  608): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 2860
04-02 00:03:53.118+0900 E/RESOURCED(  676): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.447
04-02 00:03:53.128+0900 I/Tizen::System( 1188): (157) > change brightness system value.
04-02 00:03:53.128+0900 I/Tizen::App( 1188): (782) > Finished invoking application event listener for com.samsung.task-mgr, 2860.
04-02 00:03:55.731+0900 E/AUL_AMD (  608): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
04-02 00:03:57.693+0900 W/AUL_AMD (  608): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-02 00:04:00.756+0900 I/INDICATOR(  674): clock.c: indicator_clock_changed_cb(195) > ""
04-02 00:04:00.766+0900 E/UXT     (  674): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:04
04-02 00:04:00.766+0900 I/INDICATOR(  674): clock.c: getTimeFormatted(176) > "time format : 오전 12:04"
04-02 00:04:00.766+0900 I/INDICATOR(  674): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:04"
04-02 00:04:00.766+0900 W/INDICATOR(  674): clock.c: indicator_clock_changed_cb(272) > 
04-02 00:04:00.766+0900 I/INDICATOR(  674): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146670023 Time: <font_size=31> </font_size> <font_size=31> 오전 12:04</font_size></font>"
04-02 00:04:09.675+0900 E/PKGMGR_SERVER( 5570): pkgmgr-server.c: main(2414) > package manager server start
04-02 00:04:09.725+0900 E/PKGMGR  ( 5568): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-02 00:04:09.755+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
04-02 00:04:09.765+0900 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-02 00:04:09.775+0900 E/PKGMGR_SERVER( 5570): pkgmgr-server.c: sighandler(417) > child NORMAL exit [5573]
04-02 00:04:11.787+0900 E/PKGMGR_SERVER( 5570): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-02 00:04:11.787+0900 E/PKGMGR_SERVER( 5570): pkgmgr-server.c: main(2471) > package manager server terminated.
04-02 00:04:12.057+0900 W/AUL     ( 5626): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-02 00:04:12.057+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 0
04-02 00:04:12.067+0900 I/AUL     (  608): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-02 00:04:12.077+0900 I/AUL     (  608): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-02 00:04:12.077+0900 E/AUL_AMD (  608): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-02 00:04:12.077+0900 W/AUL_AMD (  608): amd_launch.c: _start_app(2508) > caller pid : 5626
04-02 00:04:12.077+0900 E/AUL_AMD (  608): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-02 00:04:12.087+0900 E/RESOURCED(  676): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
04-02 00:04:12.087+0900 E/RESOURCED(  676): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-02 00:04:12.087+0900 W/AUL_AMD (  608): amd_launch.c: _start_app(3052) > pad pid(-4)
04-02 00:04:12.207+0900 W/AUL     (  608): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 5628, appid: org.example.client
04-02 00:04:12.207+0900 E/AUL     (  608): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-02 00:04:12.217+0900 W/AUL     ( 5626): launch.c: app_request_to_launchpad(425) > request cmd(0) result(5628)
04-02 00:04:13.208+0900 W/AUL_AMD (  608): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-02 00:04:13.208+0900 W/AUL_AMD (  608): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-02 00:04:15.520+0900 I/abc     ( 5628): abc
04-02 00:04:15.530+0900 I/CAPI_APPFW_APPLICATION( 5628): app_main.c: ui_app_main(789) > app_efl_main
04-02 00:04:16.661+0900 I/CAPI_APPFW_APPLICATION( 5628): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-02 00:04:17.212+0900 W/AUL     (  608): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(5628)
04-02 00:04:17.212+0900 W/AUL     (  608): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 5628, appid: org.example.client, status: bg
04-02 00:04:18.773+0900 E/TBM     ( 5628): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-02 00:04:52.927+0900 E/PKGMGR_SERVER( 5686): pkgmgr-server.c: main(2414) > package manager server start
04-02 00:04:52.987+0900 E/PKGMGR  ( 5684): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-02 00:04:53.017+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 14
04-02 00:04:53.017+0900 E/AUL_AMD (  608): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 5628
04-02 00:04:53.027+0900 W/AUL_AMD (  608): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-02 00:04:53.037+0900 E/PKGMGR_SERVER( 5686): pkgmgr-server.c: sighandler(417) > child NORMAL exit [5689]
04-02 00:04:54.789+0900 E/PKGMGR_SERVER( 5686): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-02 00:04:54.789+0900 E/PKGMGR_SERVER( 5686): pkgmgr-server.c: main(2471) > package manager server terminated.
04-02 00:04:56.861+0900 E/PKGMGR  ( 5775): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-02 00:04:56.941+0900 E/PKGMGR_SERVER( 5777): pkgmgr-server.c: main(2414) > package manager server start
04-02 00:04:56.991+0900 E/PKGMGR_SERVER( 5777): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-02 00:04:57.001+0900 E/PKGMGR_SERVER( 5777): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-02 00:04:57.001+0900 E/PKGMGR  ( 5775): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[57750002]
04-02 00:04:57.151+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-02 00:04:57.151+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-02 00:04:57.151+0900 W/AUL_AMD (  608): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-02 00:04:57.161+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-02 00:04:57.161+0900 I/Tizen::App( 1188): (119) > InstallationInProgress [30]
04-02 00:04:57.161+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-02 00:04:57.291+0900 W/CERT_SVC_VCORE( 5780): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-02 00:04:57.361+0900 E/rpm-installer( 5780): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-02 00:04:57.361+0900 E/rpm-installer( 5780): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-02 00:04:57.411+0900 E/PKGMGR_PARSER( 5780): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-02 00:04:57.431+0900 I/PRIVACY-MANAGER-CLIENT( 5780): SocketClient.cpp: SocketClient(37) > Client created
04-02 00:04:57.431+0900 I/PRIVACY-MANAGER-CLIENT( 5780): SocketClient.cpp: connect(62) > Client connected
04-02 00:04:57.431+0900 I/PRIVACY-MANAGER-SERVER(  925): SocketService.cpp: mainloop(230) > Got incoming connection
04-02 00:04:57.431+0900 I/PRIVACY-MANAGER-CLIENT( 5780): SocketClient.cpp: disconnect(72) > Client disconnected
04-02 00:04:57.431+0900 E/PKGMGR_CERT( 5780): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-02 00:04:57.441+0900 E/PKGMGR_CERT( 5780): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-02 00:04:57.441+0900 E/PKGMGR_CERT( 5780): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-02 00:04:57.481+0900 E/rpm-installer( 5780): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-02 00:04:57.491+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-02 00:04:57.491+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-02 00:04:57.491+0900 E/ESD     (  899): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-02 00:04:57.501+0900 W/AUL_AMD (  608): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-02 00:04:57.501+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-02 00:04:57.501+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-02 00:04:58.792+0900 E/PKGMGR_SERVER( 5777): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-02 00:04:59.143+0900 E/PKGMGR_SERVER( 5777): pkgmgr-server.c: sighandler(417) > child NORMAL exit [5780]
04-02 00:04:59.924+0900 E/PKGMGR  ( 5828): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-02 00:04:59.954+0900 E/PKGMGR_SERVER( 5777): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-02 00:04:59.964+0900 E/PKGMGR_INFO( 5777): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-02 00:04:59.974+0900 E/rpm-installer( 5777): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-02 00:04:59.974+0900 E/PKGMGR_SERVER( 5777): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-02 00:04:59.984+0900 E/PKGMGR  ( 5828): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[58280002]
04-02 00:05:00.104+0900 E/PKGMGR_INSTALLER( 5830): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-02 00:05:00.104+0900 E/rpm-installer( 5830): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-02 00:05:00.124+0900 E/rpm-installer( 5830): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-02 00:05:00.124+0900 E/rpm-installer( 5830): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-02 00:05:00.124+0900 E/rpm-installer( 5830): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-02 00:05:00.124+0900 E/rpm-installer( 5830): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-02 00:05:00.124+0900 E/rpm-installer( 5830): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-02 00:05:00.184+0900 W/CERT_SVC_VCORE( 5830): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-02 00:05:00.224+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-02 00:05:00.224+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-02 00:05:00.234+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-02 00:05:00.234+0900 I/Tizen::App( 1188): (119) > InstallationInProgress [30]
04-02 00:05:00.234+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-02 00:05:00.404+0900 E/rpm-installer( 5830): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-02 00:05:00.404+0900 E/rpm-installer( 5830): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-02 00:05:00.414+0900 E/rpm-installer( 5830): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-02 00:05:00.414+0900 E/rpm-installer( 5830): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-02 00:05:00.414+0900 E/rpm-installer( 5830): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-02 00:05:00.414+0900 E/rpm-installer( 5830): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-02 00:05:00.414+0900 E/PKGMGR_PARSER( 5830): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-02 00:05:00.424+0900 E/PKGMGR_PARSER( 5830): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-02 00:05:00.454+0900 I/PRIVACY-MANAGER-CLIENT( 5830): SocketClient.cpp: SocketClient(37) > Client created
04-02 00:05:00.664+0900 E/PKGMGR_PARSER( 5830): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-02 00:05:00.684+0900 E/PKGMGR_CERT( 5830): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-02 00:05:00.684+0900 E/PKGMGR_CERT( 5830): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 108
04-02 00:05:00.684+0900 E/PKGMGR_CERT( 5830): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 108
04-02 00:05:00.684+0900 E/PKGMGR_CERT( 5830): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
04-02 00:05:00.684+0900 E/PKGMGR_CERT( 5830): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 3
04-02 00:05:00.684+0900 E/PKGMGR_CERT( 5830): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 3
04-02 00:05:00.684+0900 E/PKGMGR_CERT( 5830): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
04-02 00:05:00.694+0900 E/PKGMGR_CERT( 5830): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-02 00:05:00.694+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-02 00:05:00.694+0900 I/Tizen::App( 1188): (119) > InstallationInProgress [60]
04-02 00:05:00.694+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-02 00:05:00.714+0900 E/rpm-installer( 5830): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-02 00:05:00.734+0900 E/rpm-installer( 5830): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-02 00:05:00.734+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-02 00:05:00.734+0900 I/Tizen::App( 1188): (119) > InstallationInProgress [100]
04-02 00:05:00.734+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-02 00:05:00.754+0900 I/INDICATOR(  674): clock.c: indicator_clock_changed_cb(195) > ""
04-02 00:05:00.764+0900 E/UXT     (  674): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:05
04-02 00:05:00.764+0900 I/INDICATOR(  674): clock.c: getTimeFormatted(176) > "time format : 오전 12:05"
04-02 00:05:00.764+0900 I/INDICATOR(  674): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:05"
04-02 00:05:00.764+0900 W/INDICATOR(  674): clock.c: indicator_clock_changed_cb(272) > 
04-02 00:05:00.764+0900 I/INDICATOR(  674): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146643347 Time: <font_size=31> </font_size> <font_size=31> 오전 12:05</font_size></font>"
04-02 00:05:00.794+0900 E/PKGMGR_SERVER( 5777): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-02 00:05:02.596+0900 I/Tizen::App( 1188): (1894) > PackageEventHandler - req: 11880002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-02 00:05:02.596+0900 I/Tizen::App( 1188): (78) > Installation is Completed. [Package = org.example.client]
04-02 00:05:02.596+0900 I/Tizen::App( 1188): (671) > Enter. package(org.example.client), installationResult(0)
04-02 00:05:02.606+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-02 00:05:02.606+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-02 00:05:02.606+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-02 00:05:02.636+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-02 00:05:02.646+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-02 00:05:02.646+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-02 00:05:02.646+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-02 00:05:02.646+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-02 00:05:02.646+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-02 00:05:02.656+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-02 00:05:02.656+0900 I/Tizen::App( 1188): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-02 00:05:02.656+0900 E/HOME_APPS(  850): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-02 00:05:02.656+0900 E/cluster-home(  850): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-02 00:05:02.656+0900 W/HOME_APPS(  850): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-02 00:05:02.686+0900 E/PKGMGR_SERVER( 5777): pkgmgr-server.c: sighandler(417) > child NORMAL exit [5830]
04-02 00:05:02.696+0900 I/Tizen::App( 1188): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-02 00:05:02.716+0900 E/util-view(  850): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-02 00:05:02.716+0900 I/Tizen::App( 1188): (416) > appName = [client]
04-02 00:05:02.716+0900 I/Tizen::App( 1188): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-02 00:05:02.716+0900 E/PKGMGR_INFO( 1188): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-02 00:05:02.716+0900 I/Tizen::App( 1188): (683) > Application count(1) in this package
04-02 00:05:02.716+0900 I/Tizen::App( 1188): (840) > Enter.
04-02 00:05:02.726+0900 W/HOME_APPS(  850): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-02 00:05:02.736+0900 I/Tizen::App( 1188): (416) > appName = [client]
04-02 00:05:02.736+0900 I/Tizen::App( 1188): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-02 00:05:02.736+0900 I/Tizen::App( 1188): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-02 00:05:02.736+0900 I/Tizen::App( 1188): (131) > Enter
04-02 00:05:02.736+0900 I/Tizen::App( 1188): (703) > Exit.
04-02 00:05:02.736+0900 I/Tizen::App( 1188): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-02 00:05:02.746+0900 I/Tizen::App( 1188): (137) > org.example.client does not have launch condition
04-02 00:05:02.746+0900 I/Tizen::App( 1188): (883) > Exit.
04-02 00:05:02.796+0900 E/PKGMGR_SERVER( 5777): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-02 00:05:02.796+0900 E/PKGMGR_SERVER( 5777): pkgmgr-server.c: main(2471) > package manager server terminated.
04-02 00:05:06.800+0900 W/AUL     ( 5885): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-02 00:05:06.800+0900 W/AUL_AMD (  608): amd_request.c: __request_handler(906) > __request_handler: 0
04-02 00:05:06.810+0900 I/AUL     (  608): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-02 00:05:06.820+0900 I/AUL     (  608): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-02 00:05:06.820+0900 E/AUL_AMD (  608): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-02 00:05:06.820+0900 W/AUL_AMD (  608): amd_launch.c: _start_app(2508) > caller pid : 5885
04-02 00:05:06.820+0900 E/AUL_AMD (  608): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-02 00:05:06.820+0900 E/RESOURCED(  676): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 4
04-02 00:05:06.820+0900 E/RESOURCED(  676): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-02 00:05:06.830+0900 W/AUL_AMD (  608): amd_launch.c: _start_app(3052) > pad pid(-5)
04-02 00:05:06.830+0900 W/AUL_PAD ( 1487): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-02 00:05:06.830+0900 W/AUL_PAD ( 1487): launchpad.c: __send_result_to_caller(267) > Check app launching
04-02 00:05:06.840+0900 I/abc     ( 2797): abc
04-02 00:05:06.840+0900 I/CAPI_APPFW_APPLICATION( 2797): app_main.c: ui_app_main(789) > app_efl_main
04-02 00:05:06.840+0900 I/CAPI_APPFW_APPLICATION( 2797): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-02 00:05:06.870+0900 E/TBM     ( 2797): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-02 00:05:06.930+0900 W/AUL     (  608): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 2797, appid: org.example.client
04-02 00:05:06.930+0900 E/AUL     (  608): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-02 00:05:06.940+0900 W/AUL     ( 5885): launch.c: app_request_to_launchpad(425) > request cmd(0) result(2797)
04-02 00:05:07.191+0900 E/RESOURCED(  676): block-monitor.c: block_logging(123) > pid 2797(org.example.client) accessed /opt/usr/media/MyApp/test.txt
04-02 00:05:07.241+0900 W/CRASH_MANAGER( 5901): worker.c: worker_job(1199) > 0402797636c69149105910
